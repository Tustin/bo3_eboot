using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bo3_eboot_builder.Classes;
using System.IO;
using bo3_eboot_builder.Properties;
using bo3_eboot_builder.Forms;

namespace bo3_eboot_builder
{
    public partial class Builder : Form
    {
        public byte[] eboot_buffer;
        public bool can_use_sprx = true;
        public class Mods
        {
            //let these uints be null
            public uint? steady_aim { get; set; }
            public uint? no_recoil { get; set; }
            public uint? vsat { get; set; }
            public uint? wallhack { get; set; }
            public uint? fps { get; set; }
            public uint? weapons_flag { get; set; }
            public uint? dead_bodies_flag { get; set; }
            public string load_sprx { get; set; }
        }

        public enum Build
        {
            //will add cex again shortly
            npeb_cex,
            npeb_debug,
            npeb_debug_npdrm
        }

        void control_flip(bool toggle)
        {
            steadyAim.Enabled = toggle;
            noRecoil.Enabled = toggle;
            vsat.Enabled = toggle;
            wallhack.Enabled = toggle;
            if (can_use_sprx)
                loadSPRX.Enabled = toggle;
            fpsCheckbox.Enabled = toggle;
            deadBodiesFlag.Enabled = toggle;
            weaponsFlag.Enabled = toggle;
        }
        public Builder()
        {
            InitializeComponent();
        }

        private void Builder_Load(object sender, EventArgs e)
        {
            //do some checking
            if (!Directory.Exists("tools"))
            {
                MessageBox.Show("\"tools\" folder is missing.\nPlease re-download the program and extract ALL files/folders!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (!File.Exists("tools/make_fself.exe") || !File.Exists("tools/make_fself_npdrm.exe"))
            {
                MessageBox.Show("Missing files in \"tools\" folder.\nPlease re-download the program and extract ALL files/folders!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (!File.Exists("tools/ingame_loader.exe"))
            {
                MessageBox.Show("Missing \"ingame_loader.exe\" from \"tools\" folder.\nYou may proceed but won't be able to load SPRX files!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                can_use_sprx = false;
            }

            compressEBOOTS.Checked = Settings.Default.compress;
        }

        private void loadELF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "ELF File (.elf)|*.elf";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                eboot_buffer = File.ReadAllBytes(ofd.FileName);

                byte[] magic = new byte[4];
                Array.Copy(eboot_buffer, magic, magic.Length);

                if (Functions.verify_magic(magic))
                {
                    status.Text = "Successfully loaded " + ofd.SafeFileName;
                    control_flip(true);
                    buildToolStripMenuItem.Enabled = true;
                }
                else
                {
                    status.Text = "Bad file header. Please make sure you're using a proper EBOOT.ELF.";
                    control_flip(false);
                    buildToolStripMenuItem.Enabled = false;
                }
            }
        }

        void build(Build type)
        {
            // :)
            Random rand = new Random();
            if (rand.Next(0, 1000000) % 1000 == 0)
                status.Text = "Infiltrating Rebel forces....";
            else
                status.Text = "Working...";

            Mods mods = new Mods();

            if (wallhack.Checked)
                mods.wallhack = 0x38C0FFFF;

            if (steadyAim.Checked)
                mods.steady_aim = 0x2C040000;

            if (noRecoil.Checked)
                mods.no_recoil = 0x60000000;

            if (vsat.Checked)
                mods.vsat = 0x60000000;

            if (loadSPRX.Checked && !string.IsNullOrEmpty(sprxName.Text))
                mods.load_sprx = sprxName.Text;

            if (fpsCheckbox.Checked)
                mods.fps = 0x60000000;

            if (weaponsFlag.Checked)
                mods.weapons_flag = 0x38C0FFFF;

            if (deadBodiesFlag.Checked)
                mods.dead_bodies_flag = 0x38C0FFFF;

            switch (Functions.compile(eboot_buffer, mods, Build.npeb_debug))
            {
                case "good":
                    status.Text = "Successfully created EBOOT";
                    break;
                case "nodir":
                    status.Text = "ERROR: \"tools\" directory is missing. Please redownload and extract all files and folders!";
                break;
                case "noeboot":
                    status.Text = "ERROR: Failed to build EBOOT. Please try again.";
                break;
            }
        }
        private void buildDebug_Click(object sender, EventArgs e)
        {
            //use task with lambda expression for asynchronous-goodness
            Task.Factory.StartNew(() => build(Build.npeb_debug));
        }

        private void loadSPRX_CheckedChanged(object sender, EventArgs e)
        {
            sprxName.Enabled = loadSPRX.Checked;
            sprxName.Enabled = loadSPRX.Checked;
        }

        private void compressEBOOTS_Click(object sender, EventArgs e)
        {
            compressEBOOTS.Checked = !compressEBOOTS.Checked;
            Settings.Default.compress = compressEBOOTS.Checked;
            Settings.Default.Save();
        }

        private void buildCEX_Click(object sender, EventArgs e)
        {
            //use task with lambda expression for asynchronous-goodness
            Task.Factory.StartNew(() => build(Build.npeb_cex));
        }

        private void buildDebugNPDRM_Click(object sender, EventArgs e)
        {
            //use task with lambda expression for asynchronous-goodness
            Task.Factory.StartNew(() => build(Build.npeb_debug_npdrm));
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}

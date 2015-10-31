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

namespace bo3_eboot_builder
{
    public partial class Builder : Form
    {
        public byte[] eboot_buffer;
        void control_flip(bool toggle)
        {
            steadyAim.Checked = toggle;
            noRecoil.Checked = toggle;
        }
        public Builder()
        {
            InitializeComponent();
        }

        private void Builder_Load(object sender, EventArgs e)
        {
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
                }
                else
                {
                    status.Text = "Bad file header. Please make sure you're using a proper EBOOT file.";
                    control_flip(false);
                }
            }
        }
    }
}

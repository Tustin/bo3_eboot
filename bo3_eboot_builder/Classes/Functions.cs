using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bo3_eboot_builder.Properties;
using System.Windows.Forms;

namespace bo3_eboot_builder.Classes
{
    class Functions
    {
        public static bool verify_magic(byte[] imagic)
        {
            Array.Reverse(imagic);

            uint input_magic = BitConverter.ToUInt32(imagic, 0);

            if (input_magic == Constants.elf_magic)
                return true;

            return false;
        }
        public static byte[] write_bytes(byte[] buffer, uint address, uint data)
        {

            //fuck yo binary writers
            byte[] temp = BitConverter.GetBytes(data);
            Array.Reverse(temp);

            //oh yeah this is real nice aint it
            for (int i = 0; i < temp.Length; i++)
                buffer[address + i] = temp[i];

            return buffer;
        }
        public static string compile(byte[] buffer, Builder.Mods mod_buffer, Builder.Build type)
        {
            if (File.Exists("EBOOT-DEX.BIN.bak"))
                File.Delete("EBOOT-DEX.BIN.bak");

            if (File.Exists("EBOOT-CEX.BIN.bak"))
                File.Delete("EBOOT-CEX.BIN.bak");

            if (File.Exists("EBOOT-DEX.BIN"))
                File.Move("EBOOT-DEX.BIN", "EBOOT-DEX.BIN.bak");

            if (File.Exists("EBOOT-CEX.BIN"))
                File.Move("EBOOT-CEX.BIN", "EBOOT-CEX.BIN.bak");

            bool using_sprx = false;
            string compress_eboot = Settings.Default.compress ? "-c " : "";
            string out_file = "EBOOT.ELF";
            switch (type)
            {
                case Builder.Build.npeb_cex:
                    out_file = "EBOOT-CEX.ELF";
                    break;

                default:
                    out_file = "EBOOT-DEX.ELF";
                    break;
            }
            if (mod_buffer.steady_aim != null)
                buffer = write_bytes(buffer, Constants.steady_aim, (uint)mod_buffer.steady_aim);

            if (mod_buffer.no_recoil != null)
                buffer = write_bytes(buffer, Constants.no_recoil, (uint)mod_buffer.no_recoil);

            if (mod_buffer.wallhack != null)
                buffer = write_bytes(buffer, Constants.chams, (uint)mod_buffer.wallhack);

            if (mod_buffer.vsat != null)
            {
                buffer = write_bytes(buffer, Constants.vsat_1, (uint)mod_buffer.vsat);
                buffer = write_bytes(buffer, Constants.vsat_2, (uint)mod_buffer.vsat);
            }

            if (mod_buffer.fps != null)
                buffer = write_bytes(buffer, Constants.fps, (uint)mod_buffer.fps);

            if (mod_buffer.weapons_flag != null)
                buffer = write_bytes(buffer, Constants.weapons_flag, (uint)mod_buffer.weapons_flag);

            if (mod_buffer.dead_bodies_flag != null)
                buffer = write_bytes(buffer, Constants.dead_bodies_flag, (uint)mod_buffer.dead_bodies_flag);

            if (mod_buffer.red_boxes != null)
            {
                buffer = write_bytes(buffer, Constants.redboxes_1, (uint)mod_buffer.red_boxes);
                buffer = write_bytes(buffer, Constants.redboxes_2, (uint)mod_buffer.red_boxes);
            }

            //just patch the blur anyways because it's annoying
            buffer = write_bytes(buffer, Constants.no_blur, mod_buffer.no_blur);

            File.WriteAllBytes(out_file, buffer);


            if (!string.IsNullOrEmpty(mod_buffer.load_sprx))
            {
                if (mod_buffer.load_sprx.IndexOf(".sprx") == -1)
                    mod_buffer.load_sprx += ".sprx";

                Process sprx = new Process();
                using_sprx = true;
                sprx.StartInfo.FileName = "ingame_loader.exe";
                sprx.StartInfo.Arguments = out_file + " /dev_hdd0/tmp/" + mod_buffer.load_sprx + " EBOOT-SPRX.ELF";
                sprx.StartInfo.CreateNoWindow = true;
                sprx.StartInfo.UseShellExecute = false;
                sprx.Start();

                //we want to wait so it doesn't proceed with an unfinished file.
                sprx.WaitForExit();
            }
            
            Process compile = new Process();

            if (using_sprx)
                out_file = "EBOOT-SPRX.ELF";

            switch (type)
            {
                case Builder.Build.npeb_cex:
                    //todo
                    break;

                case Builder.Build.npeb_debug:
                    compile.StartInfo.FileName = "make_fself.exe";
                    compile.StartInfo.Arguments = compress_eboot + out_file + " EBOOT-DEX.BIN";
                    compile.StartInfo.CreateNoWindow = true;
                    compile.StartInfo.UseShellExecute = false;
                    compile.Start();
                    break;

                case Builder.Build.npeb_debug_npdrm:
                    compile.StartInfo.FileName = "make_fself_npdrm.exe";
                    compile.StartInfo.Arguments = compress_eboot + out_file + " EBOOT-DEX.BIN";
                    compile.StartInfo.UseShellExecute = false;
                    compile.StartInfo.CreateNoWindow = true;
                    compile.Start();
                    break;
            }

            //we want to wait so it doesn't proceed with an unfinished file.
            compile.WaitForExit();

            //clean up after ourselves
            if (File.Exists("EBOOT-DEX.BIN") || File.Exists("EBOOT-CEX.BIN"))
            {
                if (File.Exists("EBOOT-SPRX.ELF"))
                    File.Delete("EBOOT-SPRX.ELF");

                if (File.Exists("EBOOT-CEX.ELF"))
                    File.Delete("EBOOT-CEX.ELF");

                if (File.Exists("EBOOT-DEX.ELF"))
                    File.Delete("EBOOT-DEX.ELF");

                return "good";
            }

            return "noeboot";
        }
    }
}

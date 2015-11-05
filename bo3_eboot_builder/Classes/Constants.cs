using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bo3_eboot_builder.Classes
{
    class Constants
    {
        public const uint elf_magic = 0x7F454C46;

        //1.01
        public const uint no_recoil_101 = 0x18BAB0;
        public const uint steady_aim_101 = 0x74F744;
        public const uint chams_101 = 0x113F38;


        //1.02
        public const uint no_recoil = 0x17E1C0;
        public const uint steady_aim = 0x741E54; 
        public const uint chams = 0x103F38;
        public const uint fps = 0xBB784;
        public const uint weapons_flag = 0x7DC00;
        public const uint dead_bodies_flag = 0x105238; 


        //probably only need one of these but i forget which one it is
        public const uint vsat_1 = 0xB7B70; //0xC7C54;
        public const uint vsat_2 = 0xB7B8C; //0xC7C38;

    }
}

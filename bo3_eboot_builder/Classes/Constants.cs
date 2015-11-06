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
        public const uint no_recoil = 0x17E290;
        public const uint steady_aim = 0x743114;
        public const uint chams = 0x104008;
        public const uint fps = 0xBB84C;
        public const uint weapons_flag = 0x7DC88;
        public const uint dead_bodies_flag = 0x105308; 


        //probably only need one of these but i forget which one it is
        public const uint vsat_1 = 0xB7C38;
        public const uint vsat_2 = 0xB7C54; 

    }
}

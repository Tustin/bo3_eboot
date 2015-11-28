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
        public const uint no_recoil_102 = 0x17E290;
        public const uint steady_aim_102 = 0x743114;
        public const uint chams_102 = 0x104008;
        public const uint fps_102 = 0xBB84C;
        public const uint weapons_flag_102 = 0x7DC88;
        public const uint dead_bodies_flag_102 = 0x105308;
        public const uint no_blur_102 = 0x3E741C;
		
		//probably only need one of these but i forget which one it is
        public const uint vsat_1_102 = 0xB7C38;
        public const uint vsat_2_102 = 0xB7C54; 

		
		//1.03
        public const uint no_recoil = 0x17E1D0;
        public const uint steady_aim = 0x74DF4C;
        public const uint chams = 0x103C40;
        public const uint fps = 0xBB41C;
        public const uint weapons_flag = 0x7D888;
        public const uint dead_bodies_flag = 0x104F40;
        public const uint no_blur = 0x3EA75C;
        public const uint redboxes_1 = 0x572A68;
        public const uint redboxes_2 = 0x572AA0;

        //probably only need one of these but i forget which one it is
        public const uint vsat_1 = 0xB7808;
        public const uint vsat_2 = 0xB7824; 

    }
}

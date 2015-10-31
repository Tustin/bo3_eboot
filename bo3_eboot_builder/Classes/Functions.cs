using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

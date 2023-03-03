using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2023_Static__Extension_method__Enum_Homework
{
    internal static class Extension
    {
        public static bool IsCorrectPin(this string pin)
        {
            if (pin.Length==7 && pin==pin.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

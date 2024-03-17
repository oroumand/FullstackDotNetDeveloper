using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced.ExtensionSamples.Extensions
{
    public static class StringExtentions
    {
        public static bool IsNumber(this string str)
        {
            //validation
            return true;
        }
        public static bool IsCodeMelli(this string str)
        {
            //Validation
            return false;
        }
    }
}

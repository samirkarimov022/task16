using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Extention
{
    static class Helper
    {
        public static string Capitalize(this string text)
        {
            return text.Substring(0,1).ToUpper() +text.Substring(1).ToLower();
        }
        public static int Add(this int num1, int num2,int num3) 
        {
            return num1 + num2 + num3;
        }
    }
}

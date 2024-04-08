using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Extention
{
    internal class Helper
    {
        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool HsDigit(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPassword(string pass)
        {
           
            if (pass.Length >= 8)
            {

                for (int i = 0; i < pass.Length; i++)
                {

                    if (char.IsDigit(pass[i]))
                    {

                        for(int J = 0; J < pass.Length; J++)
                        {

                            if (!char.IsLower(pass[J]))
                            {

                                for(int k = 0; k < pass.Length; k++)
                                {

                                    if ((char.IsUpper(pass[k])))
                                    {


                                        return true;
                                    }
                                }
                            }

                        }
                    }
                }                
            }
            Console.WriteLine("parol guclu deyil");
            return false;
        }
        public static string Capitalize(string text) 
        {
           return text.Substring(0,1).ToUpper() + text.Substring(1).ToLower();
        }


    }
}

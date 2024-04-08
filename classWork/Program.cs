using ClassWork;
using ClassWork.Extention;

namespace classWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "saMir";
            //Console.WriteLine( Helper.Capitalize(text));
            //Console.WriteLine(5.Add(10, 15));
            //IsEven(null);

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                Console.WriteLine(item.ToString());
            }

        }
        //static void IsEven(int? num) 
        //{
        //    if (num == null) { Console.WriteLine("wrong"); }
        //    else { Console.WriteLine(num%2==0); }
            
        //}
    }
}

using Extension.Extention;
using Extension.Task2;

namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "samir";
            //Console.WriteLine(Helper.HsDigit(text));

            //Console.WriteLine(Helper.CheckPassword("samFser1"));
            //Console.WriteLine(Helper.Capitalize("parOl"));



            Student std = new Student("samir","karimov");
            Student std2 = new Student("garib", "garibzade");
            Student std3 = new Student("emil", "pasayev");
            Student std4 = new Student("shahin", "alizade");
            Group group = new Group("AB-106");
            Group group1 = new Group("AB-105");

            group1.AddStudent(std);
            group1.AddStudent(std2);
            group1.AddStudent(std3);
            group1.AddStudent(std4);

            group1.GetGroupInfo();
            Group.AddGroup(group1);
            Console.WriteLine(Group.GetGroup(0));

        }
    }
}

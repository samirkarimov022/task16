using Extension.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Task2
{
    internal class Student:Helper
    {
        static int _count = 1;
        public int Id { get; set; }
        private string _name;
        private string _surname;

        public Student()
        {
            
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (IsLatter(value))
                {
                    _name = value;
                }
                else if (!IsLatter(value))
                {
                    Console.WriteLine("adi duzgun girin");
                }
            }

        }

        public string Surname 
        {
            get { return _surname; }
            set
            {
                if (IsLatter(value))
                {
                    _surname = value;
                }
                else if (!IsLatter(value))
                {
                    Console.WriteLine("soyadinizi duzgu girin");
                }
            }
            
        }

        public Student(string name, string surname)
        {
            Name = Helper.Capitalize(name);
            Surname = Helper.Capitalize(surname);
            Id = _count++;
        }
        private static bool IsLatter(string text) 
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
            return true;
                }
            }
                   return false;
        }


        public void GetInfo()
        {
            Console.WriteLine($"ad: {_name} soyad: {_surname} id: {Id}");
        }

    }
}

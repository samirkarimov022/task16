using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Task2
{
    internal class Group:Student
    {
        private static int _count = 1;
        public static Group[] Groups = new Group[0];
        public Student[] Students = new Student[0];
        public int GroupId { get; }
        private string _groupName;

        public Group(string groupname)
        {
            GroupName = groupname;
            Students = new Student[0];
            Groups = new Group[0];
            GroupId = _count;
            _count++;
        }


        public string GroupName
        {
            get { return _groupName; }
            set
            {
                if (value.Length > 0)
                {
                    _groupName = value;
                }
                else
                {
                    Console.WriteLine("qrupu duzgun girilmeyib");
                }

            }
        }





        public void GetGroupInfo()
        {
            Console.WriteLine($"grup adi:{_groupName}\ngrup ID: {GroupId}");
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }

        public Student GetStudent(int id)
        {

            for (int i = 0; i < Students.Length; i++)
            {
                if (i == id)
                {
                    return Students[i];
                }
            }
            return null;

        }

        public void AddStudent(Student student)
        {

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void Search(string info)
        {

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == info && Students[i].Surname == info)
                {
                    Students[i].GetInfo();
                }
            }

        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }


        public override string ToString()
        {
            return $"Grup Id: {GroupId}, Grup adi: {GroupName}, Telebe sayi: {Students.Length}";
        }


        public static void AddGroup(Group newGroup)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = newGroup;
        }

        public static void RemoveGroup(int id)
        {
            int k = 0;
            Group[] newAray = new Group[Groups.Length - 1];
            for (int j = 0; j < Groups.Length; j++)
            {
                if (id != j)
                {
                    newAray[k] = Groups[j];
                    k++;
                }
                Groups = newAray;
            }
        }

        public static Group GetGroup(int id)
        {

            for (int i = 0; i < Groups.Length; i++)
            {
                if (i == id)
                {
                    return Groups[i];
                }
            }
            Console.WriteLine("null");
            return null;

        }

    }
}

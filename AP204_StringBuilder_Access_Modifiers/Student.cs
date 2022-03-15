using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_StringBuilder_Access_Modifiers
{
    class Student
    {
        public string Name;
        private string _group;
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                if(value.Length == 6 && value.Contains("P"))
                {
                    _group = value;
                }
                else
                {
                    Console.WriteLine("Group adi teyin oluna bilmedi");
                }
            }
        }


        public Student(string name, string group)
        {
            Name = name;
            Group = group;
        }

        //public string getGroup()
        //{
        //    return _group;
        //}

        //public void setGroup(string group)
        //{
        //    if(group.Length == 6)
        //    {
        //        _group = group;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Qeyd olunan qrup duzgun formatda deyil");
        //    }
        //}
    }
}

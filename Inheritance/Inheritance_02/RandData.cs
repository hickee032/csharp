using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lec {
    internal class RandData {

        Random rd= new Random();

        string[] name = { "HONG", "KIM", "LEE", "PACK", "JIN", "YU" };
        char[] gender = { '남', '여' };
        string[] job = { "학생", "강사" };

        private int age;

        public string Name { get => name[rd.Next(name.Length)];}
        public char Gender { get => gender[rd.Next(gender.Length)];}
        public int Age { get => rd.Next(20, 50); }
        public string Job { get => job[rd.Next(job.Length)];}
    }
}

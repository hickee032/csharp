using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_Lec {
    internal class Lecture {
        
        private string lang;

        public Lecture(string aLang) {
            this.lang = aLang;
        }

        public virtual void Announce() {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"대학교 {lang} 강좌");
            Console.WriteLine("----------------------------");
            Console.WriteLine("[ 기본 강의 내용 ]");
            Console.WriteLine($"{lang} 기본 문법 학습");
            Console.WriteLine($"{lang} 기본 로직 학습");
            Console.WriteLine("----------------------------");
        }

        public string getLang() {
            return lang;
        }
    }
    internal class Subject : Lecture {

        private string sub1;
        private string sub2;

        public Subject (string lang, string sub1, string sub2) : base(lang) {

            this.sub1 = sub1;
            this.sub2 = sub2;
        }

        public override void Announce() {
            base.Announce();
            Console.WriteLine("[ 추가 강의 내용 ]");
            Console.WriteLine($"{base.getLang()} {sub1} 기본 문법 학습");
            Console.WriteLine($"{sub2}  학습");
            Console.WriteLine("----------------------------");
        }
    }

    internal class Entry : Subject {

        Random rd = new Random();

        string[] name = { "KIM", "PACK", "YUN", "LEE", "SEO", "CHI", "JI" };
        char[] gender = { 'M', 'F' };
        int age;
        string[] job = { "STUDENT", "TEACHER" };

        string aName;
        char aGender;
        int aAge;
        string aJob;

        public Entry(string lang, string sub1, string sub2) : base(lang,sub1,sub2) {

            this.aName = name[rd.Next(name.Length)];
            this.aAge = rd.Next(20,50);
            this.aGender = gender[rd.Next(gender.Length)];
            this.aJob = job[rd.Next(job.Length)];

        }

        public override void Announce() {
            base.Announce();
        }
        public void ShowStudent() {
            Console.WriteLine("번호\t이름\t성별\t나이\t직업");
            for (int i = 0; i < 6; i++) {
                Console.WriteLine(string.Format("{0:D2}\t", i)+$"{name[rd.Next(name.Length)]}\t{gender[rd.Next(gender.Length)]}\t" +
                    $"{rd.Next(20,60)}\t{job[rd.Next(job.Length)]}");
            }
        }


        public string Name { get => name[rd.Next(name.Length)];}
        public char Gender { get => gender[rd.Next(gender.Length)]; }
        public int Age { get => rd.Next(20, 60); }
        public string Job { get => job[rd.Next(job.Length)];}
    }

}

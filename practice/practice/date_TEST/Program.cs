using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST {
    internal class Program {
        static void Main(string[] args) {
            //Random rand = new Random();

           // Console.WriteLine(((rand.Next(10,50))/10)*10);

            char a = '2';

            Console.WriteLine(int.Parse(a.ToString()));
            //int.Parse(a.ToString());

            //string nameR = ((char)rand.Next(65, 91)).ToString() + 
            //    ((char)rand.Next(65, 91)).ToString() + ((char)rand.Next(65, 91)).ToString();

            //Console.WriteLine(nameR);

            Random rand = new Random();
            DateTime start = new DateTime(1998, 1, 1);
            int dateR = ((TimeSpan)(DateTime.Today - start)).Days;

            Console.WriteLine("전체 날짜 : "+ start.AddDays(rand.Next(dateR)));

            DateTime dt = start.AddDays(rand.Next(dateR));

            Console.WriteLine("날짜 : " + dt.ToString("yyyy/MM/dd"));

            



            //Console.WriteLine(dateR);
            //10202
            //int d = dateR % 100;
            //string ds = Convert.ToString(d).PadLeft(2, '0');
            //int m = (dateR / 100) % 10;
            //string ms = Convert.ToString(m).PadLeft(2, '0');
            //int y = dateR / 1000;
            //string ys = Convert.ToString(y).PadLeft(2, '0');
            //Console.WriteLine($"check : {y}/{ms}/{ds}");

        }
    }
}

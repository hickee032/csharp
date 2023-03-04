using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_01_PR {
    internal class List_MaxMin {
        static void Main(string[] args) {

            List<int> list = new List<int>();
            Console.WriteLine("숫자의 개수를 입력");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("숫자를 입력");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int maxValue = list[0];
            int minvalue = list[0];

            int length = list.Count;


            for (int i = 0; i < length; i++) {

                if (maxValue < list[i]) {
                    maxValue = list[i];
                }
                if (minvalue > list[i]) {
                    minvalue = list[i];
                }
            }

            Console.WriteLine($"최소값은 {minvalue}" + " " + $"최대값은 {maxValue}");


            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciCalculator_01 {
    internal class SciCalculator_01 {
        static void Main(string[] args) {

            //3*(2+1)-4 >> 321+*4-
            Stack<char> stOper = new Stack<char>();
            List<char> liNum = new List<char>();

            string input = Console.ReadLine();
            char[] arrInput = input.ToCharArray();

            for (int i = 0; i < arrInput.Length; i++) {
                if (char.IsNumber(arrInput[i])) {
                    liNum.Add(arrInput[i]);
                    Console.WriteLine("1:" + arrInput[i].ToString());
                }
                else if (stOper.Count() == 0) {
                    stOper.Push(arrInput[i]);
                    Console.WriteLine("2:" + arrInput[i].ToString());
                }
                else {
                    if (arrInput[i] == '(') {
                        stOper.Push(arrInput[i]);
                        continue;
                    }
                    else if (arrInput[i] == '(') {
                        char sc = ' ';
                        while (true) {
                            //Console.WriteLine(sc);
                            //Console.WriteLine("count :"+stOper.Count());
                            
                            if (sc == ')') {
                                break;
                            }
                            else {
                                liNum.Add(sc);
                            }
                            sc = stOper.Pop();
                        }
                        continue;
                    }
                    if (arrInput[i] == '*' || arrInput[i] == '/') {
                        stOper.Push(arrInput[i]);
                    }
                    else {
                        while (stOper.Count() != 0) {
                            if (arrInput[i] == '+' || arrInput[i] == '-') {
                                liNum.Add(stOper.Pop());
                            }
                            else {
                                break;
                            }
                        }
                        stOper.Push(arrInput[i]);
                    }
                }
            }
            char sa = ' ';
            while (stOper.Count != 0) {

                sa = Convert.ToChar(stOper.Pop());
                if (sa == '(') {
                    liNum.Add(sa);
                }
            }

         

            /*
            Stack<char> calstack = new Stack<char>();

            int ca1 = 0;
            int ca2 = 0;

            for (int i = 0; i < liNum.Count; i++) {
                if (char.IsNumber(Convert.ToChar(liNum[i]))) {
                    calstack.Push(liNum[i]);
                }
                else {
                    ca2 = int.Parse(calstack.Pop());
                    Console.WriteLine("ca2" + ca2);
                    ca1 = int.Parse(calstack.Pop());
                    Console.WriteLine("ca1" + ca1);
                    switch (liNum[i]) {

                        case "+":
                            calstack.Push((ca1 - ca2).ToString());
                            break;

                        case "-":
                            calstack.Push((ca1 - ca2).ToString());
                            break;

                        case "*":
                            calstack.Push((ca1 * ca2).ToString());
                            break;

                        case "/":
                            calstack.Push((ca1 / ca2).ToString());
                            break;
                    }

                }

            }

            Console.WriteLine(calstack.Pop().ToString());

            */
        }
    }
}

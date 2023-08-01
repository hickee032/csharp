using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciCalculator_02 {
    internal class SciCalculator_02 {

        //3*(2+1)-4 >> 321+*4-
        public static int Priority(char c) {
            switch (c) {
                case '*':
                case '/':
                    return 3;

                case '+':
                case '-':
                    return 2;

                case '(':
                    return 1;

                default:
                    return -1;
            }
        }

        static void Main(string[] args) {

            //3*(2+1)-4  -> 321+*4-

            Stack<char> opStack = new Stack<char>();
            List<char> numList = new List<char>();

            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++) {

                if (char.IsNumber(arr[i])) {
                    numList.Add(arr[i]);
                }
                else if (opStack.Count == 0) {
                    opStack.Push(arr[i]);
                }
                else {
                    if (arr[i] == '(') {
                        opStack.Push(arr[i]);
                        Console.WriteLine($"1.numLi 내부 : " + string.Join(",", numList.ToArray()));
                        Console.WriteLine($"1.operSt 내부 : " + string.Join(",", opStack.ToArray()));
                        continue;
                    }
                    else if (arr[i] == ')') {
                        char temp = ' ';
                        while (true) {

                            temp = opStack.Pop();
                            Console.WriteLine("1.temp : " + temp);
                            if (temp == '(') {
                                break;
                            }

                            else {
                                Console.WriteLine("2.temp : " + temp);
                                //opStack.Push(temp);
                                numList.Add(temp);
                            }
                        }
                        continue;
                    }
                   
                    if (Priority(arr[i])> Priority(opStack.Peek())) {
                        opStack.Push(arr[i]);
                    }
                    else {
                        while (opStack.Count !=0) {
                            if (Priority(arr[i]) <= Priority(opStack.Peek())) {
                                numList.Add(opStack.Pop());
                                
                            }
                            else {
                                break;
                            }
                        }
                        opStack.Push(arr[i]);
                    } 
                }
            }

            char temp2 = ' ';
            while (opStack.Count !=0) {
                temp2 = opStack.Pop();
                if (temp2 !='(') {
                    numList.Add(temp2);
                }
            }

            Console.WriteLine($"1.numLi 내부 : " + string.Join(",", numList.ToArray()));
            Console.WriteLine($"9.operSt 내부 : " + string.Join(",", opStack.ToArray()));

            int num1 = 0, num2 = 0;
            for (int i = 0; i < numList.Count; i++) {

                Console.WriteLine(numList[i]);
                if (char.IsNumber(numList[i])) {
                    opStack.Push(numList[i]);
                }
                else {
                    num1 = (int)opStack.Pop()-48;
                    num2 = (int)opStack.Pop()-48;

                    Console.WriteLine($"num1 : " + num1);
                    Console.WriteLine($"num2 : " + num2);

                }
                switch (numList[i]) {

                    case '+':
                        opStack.Push(((char)((num2 + num1) + 48)));
                        break;

                    case '-':
                        opStack.Push(((char)((num2 - num1) + 48)));
                        break;

                    case '*':
                        opStack.Push(((char)((num2 * num1)+48)));
                        break;

                    case '/':
                        opStack.Push(((char)((num2 / num1) + 48)));
                        break;
                }
            }

            Console.WriteLine($"1.numLi 내부 : " + string.Join(",", numList.ToArray()));
            Console.WriteLine($"9.operSt 내부 : " + string.Join(",", opStack.ToArray()));


        } 
     }         
}

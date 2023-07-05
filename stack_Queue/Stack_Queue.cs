using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue {
    internal class Stack_Queue {
        static void Main(string[] args) {
            //선형 자료구조
            //스택 Stack - LIFO(후입선출) 마지막에 들어온 것이 먼저 나감
            //Push 데이터를 넣는 것
            //Pop 데이터를 가져오는 것 (스택에 데이터가 사라짐)
            //Peek 데이터를 확인 
            Stack stack1 = new Stack();

            //비어있는 스택 생성
            Stack<string> stack = new Stack<string>();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            //실제 들어있는 데이터를 확인 (빼지 않음)
            string sPeek = stack.Peek();
            Console.WriteLine($"1.stack 조회 : {sPeek}");

            //4-3-2-1 가 존재함
            Console.WriteLine($"2.stack 내부 : " + string.Join("-", stack.ToArray()));

            //stack 데이터를 가져옴 (마지막 데이터)
            string spop = stack.Pop(); //4가 사라짐
            //3-2-1 가 존재함
            Console.WriteLine($"3.stack 내부 : " + string.Join("-", stack.ToArray()));


            Console.WriteLine("-------------------------------------------------");

            //큐 - Queue - FIFO(선입선출) 먼저 들어온것이 먼저 나감
            //Enqueue 데이터를 넣는것
            //Dequeue 데이터를 가져오는 것
            Queue queue1 = new Queue();

            var queue2 = new Queue();

            //Queue 클래스 객체 생성
            Queue<string> queue = new Queue<string>();

            //queue 데이터 추가
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");

            string qPeek = queue.Peek();
            Console.WriteLine($"1.queue 조회 : {qPeek}");
            Console.WriteLine($"2.queue 내부 : " + string.Join("-", queue.ToArray()));

            //queue의 데이터를 가져옴 (처음데이터) 
            string qde = queue.Dequeue(); // 1이 사라짐
            Console.WriteLine($"3.queue 내부 : " + string.Join("-", queue.ToArray()));

            //비선형 자료구조
            //tree(트리) - 루트 노드 - 하위 노드 (조상 - 자식) 

            //graph(그래프)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_01 {
    internal class Frequency {
        static void Main(string[] args) {

            //이름 4개의 이름
            //랜덤으로 20개의 이름을 리스트에 저장
            //각 각 이름의 빈도수 확인
            //특정 이름을 입력 받아 삭제 (중복삭제)
            //특정 이름을 검색

            Random rand = new Random();
            string[] name = new string[] { "Hong", "Kim", "Lee", "Cho" };
            List<string> nameList = new List<string>();
            int[] count = new int[4];

            for (int i = 0; i < 20; i++) {
                nameList.Add(name[rand.Next(name.Length)]);
            }

            // Console.WriteLine(string.Join(" , ", nameList));

            int listlength = nameList.Count;

            for (int i = 0; i < name.Length; i++) {

                for (int j = 0; j < listlength; j++) {

                    if (name[i].Equals(nameList[j])) {
                        count[i] += 1;
                    }
                }
            }
            //각 각 이름의 빈도수 확인
            for (int i = 0; i < name.Length; i++) {
                Console.WriteLine(name[i] + " : " + count[i]);
            }

            Console.WriteLine(string.Join(" , ", nameList));

            Console.WriteLine("삭제할 이름을 입력");
            string input = Console.ReadLine();

            //nameList.RemoveAll(x => x.Equals(input));
            for (int i = 0; i < nameList.Count; i++) {

                if (name.Equals(nameList[i])) {
                    nameList.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" , ", nameList));

            listlength = nameList.Count;


            Console.WriteLine("검색할 이름을 입력");
            string input2 = Console.ReadLine();
            for (int i = 0; i < listlength; i++) {

                if (nameList[i].Equals(input2)) {
                    Console.WriteLine(input2 + " 위치 " + i);
                }

                //string str = nameList.Find((x => x.Equals(input2)));
                //Console.WriteLine(str + " 위치 " + i);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary {
    internal class Dictionary_01 {
        static void Main(string[] args) {

            //딕셔너리 -- 키 : 값 (키와 값으로 이루어짐)
            Dictionary<int, string> dic = new Dictionary<int, string> {
                //책의 인덱스(목차)와 비슷함
                {111,"홍길동"},
                {222,"김길동"},
                {333,"박길동"}
            };
            //딕셔너리에 데이터 추가
            dic.Add(444, "이길동");

            //딕셔너리에 있는 데이터 삭제 (키 값으로 삭제 가능)
            dic.Remove(222);

            foreach (var n in dic) {
                Console.WriteLine("학번 :" + n.Key + " 이름 : " + n.Value);
                //Console.WriteLine($"학번:{n.Key}"+$"\t이름:{n.Value}");
            }
        }
    }
}

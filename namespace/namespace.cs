using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//프레임워크 라이브러리보다 큰 개념
//프레임 구조가 표준화 되어있어 누구나 사용하기 편하다

namespace _221201 {
    //namespace 충돌방지를 목적
    //하는 일이 비슷한 클래스, 구조체, 인터페이스 ,델리케이트 열거형식등을 하나의 이름아래 묶는 역할
    internal class Basic {
        //Class는 C#프로그램을 구성하는 기본 단위
        //Class 데이터 + 메소드
        //Class 안에서 변수 선언 , 함수 를 사용한다
        //C#은 최소 하나 이상의 클래스로 이루어짐

        //internal class 내부 클래스

        //함수와 메쏘드는 동일의미 
        //함수 : Class와 상관이 없는 함수 
        //메쏘드 : 객체지향 언어에서 사용되는 언어 Class와 연관이 있는 함수

        //CLR - C#으로 작성한 프로그램은 Common Language Runtime 위에서 동작함

        //주석 스타일
        // 1. /**/ 블럭주석
        // 2. // 한줄주석
        // 3. /// 메소드 주석 - 꼭 그런건 아니다
        /// <summary>
        /// 함수에 대한 정보를 이곳에 설명한다
        /// </summary>
        /// <param name="args"></param>

        //네이밍 스타일
        //1. 스네이크 방식 : std_name_male, std_name_female  --- C
        //2. 카멜 방식 : stdNameMale, stdNameFemale --- Java
        //3. 파스칼 방식 : StdNameMale, StdNameFemale    --- C#

        static void Main(string[] args) {

            //Main 프로그램의 시작
            Console.Write("Hello\n"); //enter \n
            Console.Write("Hello\n"); //Line 없으면 한줄
            Console.WriteLine("Welcome"); //Line 있으면 enter

            int num = 100;
            Char ch = '한';
            string str = "안녕하세요";

            // + 간단한 출력시 사용 기본적인 방법
            Console.WriteLine(num + str); //연결
            Console.WriteLine(ch + str);
            Console.WriteLine("인사 : " + str);

            //string.format() 이용
            string query =
                string.Format("select dno,eno,ename" + "from employee where eno = {0}", 100);

            Console.WriteLine("string.Format 형식 : " + query);

            string query1 =
                     string.Format("select dno,eno,ename" + "from employee where eno = {0} and dno = {1}"
                     , 100, 200);

            Console.WriteLine("string.Format 형식 : " + query1);

            // $ 형식
            int eno = 100, dno = 200;
            string query2 = $"select dno,eno,ename" + $"from employee where eno = {eno} and dno = {dno}";
            Console.WriteLine("$ 형식 : " + query2);

            //입력받기
            string n = Console.ReadLine(); //문자열로 입력받기
                                           //C#에서는 무조건 문자열로 입력받음

            //문자열을 숫자로 변경
            int num1 = int.Parse(n);
            int num2 = Convert.ToInt32(n);

            Console.Write("숫자를 입력하세요");
            int num3 = int.Parse(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            #region region 사용
            Console.WriteLine("코드를 접을수 있다 ");
            Console.WriteLine("오른쪽에 - 형태 클릭");
            #endregion

        }
    }
}

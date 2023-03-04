using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_01 {
    internal class Program {
        static void Main(string[] args) {

            //학생 클래스 객체 생성
            Student st= new Student(); //new Student(); 에서 인스턴스가 생성된다
            //Student(타입) st(변수)= new Student();

            //생성자
            //new 다음에 오는 Student(); <- 생성자 (메소드) 클래스와 철자가 같아야 함
            //Student() : 기본 생성자 -- ()가 비어 있음, 매개변수가 없음
            //기본생성자인 경우 생략하면 컴파일러가 자동으로 생성

            //new 를 사용하면 객체 덩어리(인스턴스)가 만들어짐 -- heap(힙)에 할당됨
            //인스턴스 안에 있는 변수 -> 인스턴스 변수
            //st가 만들어진 객체를 참조한다

            //C 구조체 쓰는 방법과 비슷 -> 객체 지향에서는 이렇게 쓰는 방법을 지양한다.(캡슐화를 사용)
            //클래스 변수에 private을 쓰면 바로 접근을 못한다
            //st.id = 1111;
            //st.name = "홍길동";
            //st.age = 20;
            //st.addr = "서울시";
            //Console.WriteLine("아이디 :" + st.id);
            //Console.WriteLine("이름 :" + st.name);

            st.setId(1111);
            st.setName("홍길동");
            st.setAge(20);
            st.setAddr("서울시");

            Console.WriteLine("아이디 :"+st.getId());
            Console.WriteLine("이름 :" + st.getName());
            Console.WriteLine("나이 :" + st.getAge());
            Console.WriteLine("주소 :" + st.getAddr());

            Console.WriteLine("-------------------------------------");

            

            Student st2 = new Student();
            //두개가 다르다 (객체가 다름)
            //new 키워드로 생성된 객체는 다 다른 객체이다
            st.showInfo();
            st2.showInfo();

            Professor pr = new Professor();

            pr.PId = 1200;
            pr.PName= "test";
            pr.PAge= 100;
            pr.setPCall("010124578");

            pr.showPInfo();

            Professor pr2 = new Professor();
            pr2.showPInfo();

            //매개변수가 있는 생성자 사용
            Student st3= new Student(1000,"김길동",50,"대구시");
            //기본생성자를 사용하는게 아닌 매개변수가 있는 생성자를 사용
            Console.WriteLine("학교 : "+ Student.SCHOOL);
            //static 변수,메소드는 클래스 변수를 사용하지 않고 클래스 명으로 접근이 가능하다
            Console.WriteLine("학교 : " + Student.gerSchool());
            st3.showInfo();
            
            

        }
    }
}

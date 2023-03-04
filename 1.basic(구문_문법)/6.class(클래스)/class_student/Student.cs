using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class_01 {
    //학생 클래스 정의
    internal class Student {
        //추상화 객체의 속성을 빠르게 파악

        //public을 써야지 어디서나 접근을 할수 있다
        //캡슐화 변수(정보)를 은닉 - 기본적으로 변수를 외부에 노출시키면 안된다
        //명시적으로 private을 붙여준다
        //인스턴스 변수 혹은 속성이라고 함
        private int id;
        private string name;
        private int age;
        private string addr;
        //상수 변수는 대문자
        //static 인스턴스 생성 메모리와는 별도의 메모리에 할당됨

        //클래스 변수 (메소드에 static이 붙으면 클래스 메소드)
        public static string SCHOOL = "경북학교";  //객체가 생성할때마다 만들어지지 않는 다(처음,최초 객체를 만들때 한번만 생성됨)
        //이후 생성된 객체는 처음 만들어진 클래스 변수를 공유 한다

        //생성자를 정의 하지 않으면 Student() 생성자로 접근이 가능하지만 생성한다면 생성한 생성자로만 접근할수 있다
        //Student(int id,string name,int age,string addr) 만 만들어 놓으면  Student() 으로는 생성, 접근을 할수 없다

        //사용자 정의 기본 생성자 생성
        public Student() {
            //객체를 생성할때 가장 빠르게 실행 (객체 생성 시점) 즉 초기화를 할수 있다
            //새로운 객체를 생성할때도 사용 가능 하다
            id= 0001;
            name = "전우치";
            age= 20;
            addr = "강원도";
        }
        //매개변수가 있는 생성자
        public Student(int id,string name,int age,string addr) {
            this.id= id;
            this.name= name;    
            this.age= age;
            this.addr= addr;

        }


        //setter 기본적인 형태
        //this : 인스턴스가 만들어질때 자기 자신의 주소값

        public void setId(int id) {
            //this : 인스턴스가 만들어질때 자기 자신의 주소값
            //public void setId(int id)에서 int id 매개변수는 class Student안에 존재하는 private int id를 가리킨다
            this.id = id;
            //this.id --> private int id;
            //id --> 매개변수 int id 를 가리킴
        }
        public void setName(string name) {
            
            this.name = name;
        }
        public void setAge(int age) {
            
            this.age = age;
        }
        public void setAddr(string addr) {
            
            this.addr = addr;
        }

        //getter
        public int getId() { 
            return this.id;
        }
        public string getName() {
            return name;
        }
        public int getAge() {
            return age;
        }
        public string getAddr() {
            return addr;
        }

        //인스턴스 안에 메소드 -> 인스턴스 메소드
        public void showInfo() {
            Console.WriteLine("SCHOOL" + SCHOOL);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("NAME : " + name);
            Console.WriteLine("AGE : " + age);
            Console.WriteLine("ADDRESS : " + addr);
        }

        //클래스 메소드 안에서는 인스턴스변수를 쓸수 없음 (반대로 인스턴스 메소드에 클래스 변수는 사용 가능함)
        /*
        public static void showInfo2() {

            Console.WriteLine("ID : " + id);
            Console.WriteLine("NAME : " + name);
            Console.WriteLine("AGE : " + age);
            Console.WriteLine("ADDRESS : " + addr);
        }
        */
        public static string gerSchool() {
            return SCHOOL;
        }


    }
}

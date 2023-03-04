using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Car {
    internal class Car_Main {
        static void Main(string[] args) {

            //1번 방식 -- 재사용이 가능
            Car car = new Car();            
            car.carinfo(); //기본 생성자

            //2번방식 -- 재사용을 못함
            //new Car().carinfo();

            car.setFac("현대");
            car.setColor("Red");
            car.setPrice(3000);
            car.setModel("싼타페");

            car.carinfo();

            Car car2 = new Car("포드","Blue",5000,"머스탱");
        }
    }
}

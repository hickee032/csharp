using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_CarMG {
    internal class Customer {

        private string cName;
        private string cTel;
        private string cAddr;
        private Car car; 

        public Customer(string name, string tel, string addr, Car car) {

            this.cName = name;
            this.cTel = tel;    
            this.cAddr = addr;
            this.car = car;
        }

        public void CustomerInfo() {

            Console.WriteLine($"고객명 : {cName}");
            Console.WriteLine($"  전화 : {cTel}");
            Console.WriteLine($"  주소 : {cAddr}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{cName} 고객의 차량 정보");
            Console.WriteLine($"모델명 : {car.getModel()}");
            Console.WriteLine($"  색상 : {car.getColor()}");
            Console.WriteLine($"  연식 : {car.getYear()}");
            Console.WriteLine($"제조사 : {car.getFac()}");
        }

        #region Getter
        public string getName() {
            return cName;
        }
        public string getTel() {
            return cTel;
        }
        public string getAddr() {
            return cAddr;
        }
        public Car getFac() {
            return car;
        }
        #endregion

        #region Setter
        public void cNameSet(string cName) {
            this.cName = cName;
        }
        public void cTelSet(string cTel) {
            this.cTel = cTel;
        }
        public void cAddrSet(string cAddr) {
            this.cAddr = cAddr;
        }
        public void carSet(Car car) {
            this.car = car;
        }
        #endregion



    }
}

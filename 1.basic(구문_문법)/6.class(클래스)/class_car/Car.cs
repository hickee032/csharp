using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Car {
    internal class Car {

        public static string DISTRIBU = "동대구 영업소";
        private string fac;
        private string color;
        private int price;
        private string model;


        public Car() {
            fac = "기아";
            color= "Black";
            price= 4000;
            model = "K7";
        }
        public Car(string fac, string color, int price, string model) {
                this.fac = fac;
                this.color = color;
                this.price = price;
                this.model = model;
        }
        public void carinfo() {
            Console.WriteLine($"대리점 : {DISTRIBU}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"제조사 : {fac}");
            Console.WriteLine($"색상 : {color}");
            Console.WriteLine($"가격 : {price}만원");
            Console.WriteLine($"모델명 : {model}");
            Console.WriteLine("---------------------");
        }



        #region setter
        public void setFac(string fac) {
            this.fac = fac;
        }
        public void setColor(string color) {
            this.color = color;
        }
        public void setPrice(int price) {
            this.price = price;
        }
        public void setModel(string model) {
            this.model = model;
        }
        #endregion

        #region getter
        public string getFac() {
            return this.fac;
        }
        public string getColor() {
            return this.color;
        }
        public int getPrice() {
            return this.price;
        }
        public string getModel() {
            return this.model;
        }
        #endregion
    }
}

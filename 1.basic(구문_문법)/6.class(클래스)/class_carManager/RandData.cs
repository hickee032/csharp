using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CarMG {
    internal class RandData {

        Random rd= new Random();

        
        private string[] name = { "Hong", "Kim", "Pack", "Lee", "Choi" };
        private string[] tel = { "010-1111-2222", "010-3333-4444", "010-5555-6666", "010-7777-8888", "010-9999-0000" };
        private string[] addr = { "서울시", "대전시", "대구시", "부산시", "인천시" };
                
        private string[] model = { "SM6", "그랜져", "K7", "소나타", "산타페" };
        private string[] color = { "Black", "Red", "Blue", "White", "Pink" };
        private int[] year = { 2016, 2017, 2018, 2019 };
        private string[] fac = { "르노", "현대", "기아", "포드" };


        


        //고객 랜덤
        public string getName() {
            return name[rd.Next(name.Length)];
        }
        public string getTel() {
            return tel[rd.Next(tel.Length)];
        }
        public string getAddr() {
            return addr[rd.Next(addr.Length)];
        }

        //자동차 랜덤
        public string getModel() {
            return model[rd.Next(model.Length)];
        }
        public string getColor() {
            return color[rd.Next(color.Length)];
        }
        public int getYear() {
            return year[rd.Next(year.Length)];
        }
        public string getFac() {
            return fac[rd.Next(fac.Length)];
        }


    }
}

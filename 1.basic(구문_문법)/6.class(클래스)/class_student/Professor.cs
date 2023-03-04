using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_01 {
    internal class Professor {

        private int pId;
        private string pName;
        private int pAge;
        private string pCall;

       public Professor() {
            pId= 10000;
            pName = "고길동";
            pAge= 100;
            pCall = "01012341234";
        }

        public int PId { get => pId; set => pId = value; }

        public string PName {
            get { return pName; }
            set { pName = value; }
        }

        public int PAge { get; set; }


        public void setPCall(string pcall) {
            this.pCall = pcall;
        }
        public string getPCall(string pcall) {

            return pCall;
        }

        public void showPInfo() {
            Console.WriteLine("ID : " + PId);
            Console.WriteLine("NAME : " + PName);
            Console.WriteLine("AGE : " + pAge);
            Console.WriteLine("CALL : " + pCall);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber_Win {
    public partial class Form1 : Form {

        private int findnum = 0; 
        private int findcount = 0;
        private int inputnum = 0;

        public Form1() {
            InitializeComponent();
            var rand = new Random();
            findnum = rand.Next(1, 21);
        }

        private void btn_start_Click(object sender, EventArgs e) {


            if (inputnum == findnum) {
                display.Text = "승리";
            }
            else {

                if (inputnum > findnum) {
                    display.Text = "보다 작은수";
                }
                else {
                    display.Text = "보다 큰수";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
   
            inputnum = int.Parse(textBox1.Text);
 
        }
    }
}

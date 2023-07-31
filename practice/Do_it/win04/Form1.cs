using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber1_Win {
    public partial class Form1 : Form {

        private int findnum = 0;
        private int chance = 0;

        public Form1() {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e) {
            var rand = new Random();
            findnum = rand.Next(1, 21);
            chance = 10;
            display.Text = "숫자를 입력하세요";
        }

        private void button1_Click(object sender, EventArgs e) {
            int inputNum = Int32.Parse(textBox1.Text);

            if (inputNum == findnum) {
                display.Text = "승리";
            }
            else {
                chance--;
                display.Text = chance + " 번 남았습니다";
            }
            if (chance <= 0) {
                display.Text = "실패";
            }

        }
    }
}

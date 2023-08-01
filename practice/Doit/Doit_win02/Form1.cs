using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Win {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            string id = "rei";
            string pass = "1234";

            string id_text = textBox1.Text;
            string pass_text = textBox2.Text;

            if (id.Equals(id_text)&&pass.Equals(pass_text)) {
                MessageBox.Show("로그인 합니다");
            }
            else {
                MessageBox.Show("로그인 실패");
            }


        }
    }
}

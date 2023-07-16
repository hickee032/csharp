using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_string {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSt_Click(object sender, EventArgs e) {
            string str = lbltext.Text;
            //문자 비교
            lblcon.Text = str.Contains("text").ToString();
            lbleq.Text = str.Equals("XXXXX").ToString();
            lbllg.Text = str.Length.ToString();
            lblrep.Text = str.Replace("text", "heart").ToString();

            string[] strsplit = str.Split(',');
            lblspl1.Text = strsplit[0].ToString();
            lblspl2.Text = strsplit[1].ToString();
            lblspl3.Text = strsplit[2].ToString();

            lblsub.Text = str.Substring(3, 5).ToString();
            lbltlr.Text = str.ToLower();// string 임
            lbltur.Text = str.ToUpper();
            lbltr.Text = str.Trim().ToString();
        }
    }
}

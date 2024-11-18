using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();
        private Form3 form3;
        private bool state1 = false;
        private bool state2 = false;
        private bool state3 = false;
        private bool state4 = false;
        private bool state5 = false;
        private bool state6 = false;
        private bool state7 = false;
        private string songs1;
        private string songs2;
        private string songs3;
        private string songs4;
        private string songs5;
        private string songs6;
        private string songs7;
        public Form1 ()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Form3 form3 = new Form3(this);
        }
        public Form1 (Form3 form3, string songs1,string songs2, string songs3, string songs4, string songs5, string songs6, string songs7, List<string> list,bool state1,bool state2,bool state3,bool state4,bool state5,bool state6,bool state7)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.form3 = form3;
            this.list = list;
            this.songs1 = songs1;
            this.songs2 = songs2;
            this.songs3 = songs3;
            this.songs4 = songs4;
            this.songs5 = songs5;
            this.songs6 = songs6;
            this.songs7 = songs7;
            this.state1 = state1;
            this.state2 = state2;
            this.state3 = state3;
            this.state4 = state4;
            this.state5 = state5;
            this.state6 = state6;
            this.state7 = state7;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(!list.Contains(tb_login.Text))
            {
                MessageBox.Show("가입명이 잘못되었습니다.");
                tb_login.Text = "";
            }
            else
            {
                MessageBox.Show("환영합니다.");
                Form form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form2.Show();
            }
        }

        private void btn_make_Click(object sender, EventArgs e)
        {
            if(tb_make.Text=="")
            {
                MessageBox.Show("가입명을 입력하세요.");
            }
            else if(list.Contains(tb_make.Text))
            {
                MessageBox.Show("이미 가입된 이름입니다.");
                tb_make.Text = "";
            }
            else
            {
                list.Add(tb_make.Text);
                MessageBox.Show("가입이 완료되었습니다.");
                tb_make.Text = "";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private string songs1 = "";
        private string songs2 = "";
        private string songs3 = "";
        private string songs4 = "";
        private string songs5 = "";
        private string songs6 = "";
        private string songs7 = "";
        private List<string> list;
        private Form3 form3;
        private Form1 form1;
        private bool state1 = false;
        private bool state2 = false;
        private bool state3 = false;
        private bool state4 = false;
        private bool state5 = false;
        private bool state6 = false;
        private bool state7 = false;
        private static int cnt1 = 0;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public Form2(Form1 form1, string songs1, string songs2, string songs3, string songs4, string songs5, string songs6, string songs7, List<string> list, bool state1, bool state2, bool state3, bool state4, bool state5, bool state6, bool state7)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.list = list;
            this.form1 = form1;
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
            if (!(btn_room1.Text == "3곡" || btn_room1.Text == "6곡" || btn_room1.Text == "10곡" || btn_room1.Text == "17곡" || btn_room1.Text == "36곡") && state1 == true)
                btn_room1.Text = songs1 + "곡";
            if (!(btn_room2.Text == "3곡" || btn_room2.Text == "6곡" || btn_room2.Text == "10곡" || btn_room2.Text == "17곡" || btn_room2.Text == "36곡") && state2 == true)
                btn_room2.Text = songs2 + "곡";
            if (!(btn_room3.Text == "3곡" || btn_room3.Text == "6곡" || btn_room3.Text == "10곡" || btn_room3.Text == "17곡" || btn_room3.Text == "36곡") && state3 == true)
                btn_room3.Text = songs3 + "곡";
            if (!(btn_room4.Text == "3곡" || btn_room4.Text == "6곡" || btn_room4.Text == "10곡" || btn_room4.Text == "17곡" || btn_room4.Text == "36곡") && state4 == true)
                btn_room4.Text = songs4 + "곡";
            if (!(btn_room5.Text == "3곡" || btn_room5.Text == "6곡" || btn_room5.Text == "10곡" || btn_room5.Text == "17곡" || btn_room5.Text == "36곡") && state5 == true)
                btn_room5.Text = songs5 + "곡";
            if (!(btn_room6.Text == "3곡" || btn_room6.Text == "6곡" || btn_room6.Text == "10곡" || btn_room6.Text == "17곡" || btn_room6.Text == "36곡") && state6 == true)
                btn_room6.Text = songs6 + "곡";
            if (!(btn_room7.Text == "3곡" || btn_room7.Text == "6곡" || btn_room7.Text == "10곡" || btn_room7.Text == "17곡" || btn_room7.Text == "36곡") && state7 == true)
                btn_room7.Text = songs7 + "곡";
        }
        public Form2(Form3 form3, string songs1, string songs2, string songs3, string songs4, string songs5, string songs6, string songs7, List<string> list)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.list = list;
            this.form3 = form3;
            this.songs1 = songs1;
            this.songs2 = songs2;
            this.songs3 = songs3;
            this.songs4 = songs4;
            this.songs5 = songs5;
            this.songs6 = songs6;
            this.songs7 = songs7;
        }
        private void btn_room1_Click(object sender, EventArgs e)
        {
            if (btn_room1.Text != "1번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state1 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();

            }
        }

        private void btn_room2_Click(object sender, EventArgs e)
        {
            if (btn_room2.Text != "2번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state2 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();

            }
        }

        private void btn_room3_Click(object sender, EventArgs e)
        {
            if (btn_room3.Text != "3번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state3 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();
            }
        }

        private void btn_room4_Click(object sender, EventArgs e)
        {
            if (btn_room4.Text != "4번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state4 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();
            }
        }

        private void btn_room5_Click(object sender, EventArgs e)
        {
            if (btn_room5.Text != "5번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state5 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();
            }
        }

        private void btn_room6_Click(object sender, EventArgs e)
        {
            if (btn_room6.Text != "6번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state6 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();
            }
        }

        private void btn_room7_Click(object sender, EventArgs e)
        {
            if (btn_room7.Text != "7번방")
            {
                MessageBox.Show("사용중인 방입니다.");
                return;
            }
            else
            {
                state7 = true;
                Form3 form3 = new Form3(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                this.Hide();
                form3.Show();
            }
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            Form4 form4= new Form4();
            form4.Show();
        }
    }
}

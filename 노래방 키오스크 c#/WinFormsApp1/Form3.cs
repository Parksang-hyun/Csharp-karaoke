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
    public partial class Form3 : Form
    {
        private List<string> list;
        private Form2 form2;
        private string songs1;
        private string songs2;
        private string songs3;
        private string songs4;
        private string songs5;
        private string songs6;
        private string songs7;
        private bool state1 = false;
        private bool state2 = false;
        private bool state3 = false;
        private bool state4 = false;
        private bool state5 = false;
        private bool state6 = false;
        private bool state7 = false;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public Form3(Form2 form2, string songs1, string songs2, string songs3, string songs4, string songs5, string songs6, string songs7,List<string> list,bool state1,bool state2,bool state3,bool state4,bool state5,bool state6,bool state7)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.list=list;
            this.form2=form2;
            this.state1=state1;
            this.state2=state2;
            this.state3=state3;
            this.state4=state4;
            this.state5=state5;
            this.state6=state6;
            this.state7=state7;
            this.songs1 =songs1;
            this.songs2 =songs2;
            this.songs3 =songs3;
            this.songs4 =songs4;
            this.songs5 =songs5;
            this.songs6 =songs6;
            this.songs7 =songs7;
        }
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if(combo_songs.SelectedItem==null)
            {
                MessageBox.Show("곡수를 선택하세요!");
                return;
            }
            if (state1 == true)
            {
                if (!(songs1=="3" || songs1=="6" || songs1=="10" || songs1=="17" || songs1=="36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs1 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs1 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs1 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs1 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs1 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
            if (state2 == true)
            {
                if (!(songs2 == "3" || songs2 == "6" || songs2 == "10" || songs2 == "17" || songs2 == "36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs2 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs2 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs2 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs2 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs2 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
            if (state3 == true)
            {
                if (!(songs3 == "3" || songs3 == "6" || songs3 == "10" || songs3 == "17" || songs3 == "36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs3 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs3 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs3 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs3 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs3 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
            if (state4 == true)
            {
                if (!(songs4 == "3" || songs4 == "6" || songs4 == "10" || songs4 == "17" || songs4 == "36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs4 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs4 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs4 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs4 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs4 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
            if (state5 == true)
            {
                if (!(songs5 == "3" || songs5 == "6" || songs5 == "10" || songs5 == "17" || songs5 == "36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs5 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs5 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs5 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs5 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs5 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
            if (state6 == true)
            {
                if (!(songs6 == "3" || songs6 == "6" || songs6 == "10" || songs6 == "17" || songs6 == "36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs6 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs6 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs6 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs6 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs6 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
            if (state7 == true)
            {
                if (!(songs7 == "3" || songs7 == "6" || songs7 == "10" || songs7 == "17" || songs7 == "36"))
                {
                    if (combo_songs.SelectedIndex == 0)
                    {
                        songs7 = "3";
                    }
                    if (combo_songs.SelectedIndex == 1)
                    {
                        songs7 = "6";
                    }
                    if (combo_songs.SelectedIndex == 2)
                    {
                        songs7 = "10";
                    }
                    if (combo_songs.SelectedIndex == 3)
                    {
                        songs7 = "17";
                    }
                    if (combo_songs.SelectedIndex == 4)
                    {
                        songs7 = "36";
                    }
                    Form2 form2 = new Form2(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list);
                    this.Hide();
                    Form1 form1 = new Form1(this, songs1, songs2, songs3, songs4, songs5, songs6, songs7, list, state1, state2, state3, state4, state5, state6, state7);
                    form1.Show();
                }
            }
                MessageBox.Show($"{combo_songs.SelectedItem}이 결제가 완료되었습니다."); 
        }
        
    }
}

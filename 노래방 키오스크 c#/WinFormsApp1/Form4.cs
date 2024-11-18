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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_water_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lb_result.Text) + int.Parse(lb_w.Text);
            lb_result.Text = Convert.ToString(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 {lb_result.Text}원이 결재 되었습니다.\n방을 선택하시면 가져다 드리겠습니다.");
            this.Close();
        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lb_result.Text) + int.Parse(lb_p.Text);
            lb_result.Text = Convert.ToString(a);
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lb_result.Text) + int.Parse(lb_h.Text);
            lb_result.Text = Convert.ToString(a);
        }

        private void btn_so_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lb_result.Text) + int.Parse(lb_s.Text);
            lb_result.Text = Convert.ToString(a);
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lb_result.Text) + int.Parse(lb_m.Text);
            lb_result.Text = Convert.ToString(a);
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lb_result.Text) + int.Parse(lb_y.Text);
            lb_result.Text = Convert.ToString(a);
        }
    }
}

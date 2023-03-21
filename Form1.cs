using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "JangGeun" && txt_PW.Text == "1234")
            {
                MessageBox.Show("로그인에 성공했습니다.", "성공");
                this.Hide();
                Calcul cal1 = new Calcul();
                cal1.Show();
            }
            else
                MessageBox.Show("아이디, 비밀번호를 확인하세요.", "실패");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

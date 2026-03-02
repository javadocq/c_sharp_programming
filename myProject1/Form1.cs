using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 버튼1을 클릭했을 때, 실행 프로그램 작성
            label1.Text = "안녕하세요. C#입니다."; // label1에 글자 출력
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 버튼2를 클릭했을 때, 실행 프로그램 작성
            label1.Text = ""; // label1에 글자 제거
        }
    }
}

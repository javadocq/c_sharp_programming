using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int iValue = 100;
            lblResult.Text = iValue.ToString(); // label에 int 값을 문자열로 변환하여 표시
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float fValue = 3.14f;
            lblResult.Text = fValue.ToString(); // label에 float 값을 문자열로 변환하여 표시
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string sValue = "Hello, World!";
            lblResult.Text = sValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_02
{
    public partial class WindowsForms_02 : Form
    {
        public WindowsForms_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = int.Parse(textBox1.Text);
            if(number%2==0)
            {
                label1.Text = "Even";
            }
            else
            {
                label1.Text = "Odd";
            }
        }
    }
}

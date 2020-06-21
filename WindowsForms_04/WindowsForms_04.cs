using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_04
{
    public partial class WindowsForms_04 : Form
    {
        public WindowsForms_04()
        {
            InitializeComponent();
        }
 
        private void btnNum(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Clear();

            Button button = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + button.Text;
        }

        private void btn_AC(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            total1 = 0;
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (double.Parse(txtDisplay.Text) * 0.01).ToString();
        }

        double total1 = 0;
        double total2 = 0;
        string opertionPerformed = "";

        private void btnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            opertionPerformed = button.Text;
            total1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(opertionPerformed)
            {
                case "+": total2 = total1 + double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                    break;
                case "-":
                    total2 = total1 - double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                    break;
                case "*":
                    total2 = total1 * double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                    break;
                case "/":
                    if (txtDisplay.Text != "0")
                    {
                        total2 = total1 / double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                    }
                    else
                        txtDisplay.Text = "Cannot divide by zero.";
                    break;
            }        
            total1 = 0;
        }

        

        
    }
}

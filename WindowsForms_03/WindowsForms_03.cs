using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_03
{
    public partial class WindowsForms_03 : Form
    {
        public WindowsForms_03()
        {
            InitializeComponent();
        }

        private void WindowsForms_03_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int n1 = random.Next(20);
            int n2 = random.Next(20);
            int n3 = random.Next(20);
            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
            if((n1+n2+n3)>21)
            {
                pictureBox1.Image = Image.FromFile
                    (@"C:\Users\ABHIJEET\Documents\Visual Studio 2019\Projects\WindowsForms\WindowsForms_03\won.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                MessageBox.Show("You have won the Game.", "Game Result");
            }
            else
            {
                
                pictureBox1.Image = Image.FromFile
                    (@"C:\Users\ABHIJEET\Documents\Visual Studio 2019\Projects\WindowsForms\WindowsForms_03\loss.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                MessageBox.Show("OOPs better luck next time.", "Game Result");
            }

        }
    }
}

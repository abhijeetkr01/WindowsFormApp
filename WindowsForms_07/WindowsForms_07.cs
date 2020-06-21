using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_07
{
      
    public partial class WindowsForms_07 : Form
    {
        public WindowsForms_07()
        {
            InitializeComponent();
            this.ActiveControl = Enum;
            Enum.Focus();
        }

        private void Enum_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ename.Focus();
            }
        }
        
        private void Ename_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Edoj.Focus();
            }
        }

        private void Edoj_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                Edep.Focus();
            }
        }

        private void Edep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Esal.Focus();
            }
        }

        List<string> enumber = new List<string>();
        List<string> edepartment = new List<string>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ename.Text == "")
                MessageBox.Show("Name cannot be null");
            if (DateTime.Parse(Edoj.Text) > DateTime.Now)
                MessageBox.Show("Date of joining  should be always less than today's date");
            if (double.Parse(Esal.Text) < 100000 && double.Parse(Esal.Text) > 50000000)
                MessageBox.Show("Salary should be between 100000 and 50000000");
            if (!enumber.Contains((Enum.Text)))
                enumber.Add(Enum.Text);
            else
                MessageBox.Show("Ecnumber should be unique.");
            if (!edepartment.Contains(Edep.Text.ToLower()))
                MessageBox.Show("Department not in the list.");
            Enum.Clear();
            Ename.Clear();
            Edoj.Text = "mm-dd-yyyy";
            Edoj.ForeColor = Color.Silver;
            Esal.Clear();
            Edep.Clear();
        }

        private void WindowsForms_07_Load(object sender, EventArgs e)
        {
            edepartment.Add("logistics");
            edepartment.Add("operations");
            edepartment.Add("sales and marketing");
            edepartment.Add("research and development");
            edepartment.Add("product development");
            edepartment.Add("finance and accounts");

        }

        private void Edoj_Enter(object sender, EventArgs e)
        {
            if (Edoj.Text == "mm-dd-yyyy")
            {
                Edoj.Text = "";
            }
            Edoj.ForeColor = Color.Black;
        }

        private void Edoj_Leave(object sender, EventArgs e)
        {
            if (Edoj.Text == "")
            {
                Edoj.Text = "mm-dd-yyyy";
                Edoj.ForeColor = Color.Silver;
            }
        }
    }
}

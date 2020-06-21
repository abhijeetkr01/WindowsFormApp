using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_05
{
    public partial class WindowsForms_05 : Form
    {
        public WindowsForms_05()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Files = Directory.GetFiles(comboBox1.SelectedItem.ToString());
            string[] Dirs = Directory.GetDirectories(comboBox1.SelectedItem.ToString());
            listBox1.Items.Clear();
            foreach (string file in Files)
                listBox1.Items.Add(file);
            foreach (string dir in Dirs)
                listBox1.Items.Add(dir);
        }

        private void WindowsForms_05_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Drive";
            DriveInfo[] ListDrive = DriveInfo.GetDrives();
            foreach (DriveInfo Drive in ListDrive)
            {
                if(Drive.IsReady)
                {
                    comboBox1.Items.Add(Drive.Name);
                }
            }   
        }      
    }
}

using System.IO;
using System.Windows.Forms;

namespace WindowsForms_06
{
    public partial class WindowsForms_06 : Form
    {
        public WindowsForms_06()
        {
            InitializeComponent();
        }

    private void textBox1_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string[] Files = Directory.GetFiles(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
            string[] Dirs = Directory.GetDirectories(textBox1.Text);
            listBox1.Items.Clear();
            foreach (string file in Files)
                listBox1.Items.Add(file);
            foreach (string dir in Dirs)
                listBox1.Items.Add(dir);
        }
    }
}
}

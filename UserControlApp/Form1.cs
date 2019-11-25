using System;
using System.Windows.Forms;

namespace UserControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Controls.Add(new UserControl1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            if (!panel1.Controls.Contains(UserControl1.Instance))
            {
                panel1.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
            }
            UserControl1.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            if (!panel1.Controls.Contains(UserControl2.Instance))
            {
                panel1.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
            }
            UserControl2.Instance.BringToFront();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class setupPage : Form
    {
        string mycolor;
        public setupPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You will need to pick a page to apply the color on");
                comboBox1.Focus();
                return;

            }
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                 mycolor = colorDialog1.Color.Name.ToString();
                 TabPage tpage = ((Form1)this.Owner).Controls.Find(comboBox1.Text, true).FirstOrDefault() as TabPage;
                // tpage.Text = textBox1.Text;
                 tpage.BackColor = colorDialog1.Color;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // TabPage tpage = ((Form1)this.ParentForm).Controls.Find(comboBox1.Text, true).FirstOrDefault() as TabPage;
           // TabPage tpage = ((Form1)this.Owner).tabPage1;
            TabPage tpage = ((Form1)this.Owner).Controls.Find(comboBox1.Text, true).FirstOrDefault() as TabPage;
            tpage.Text = textBox1.Text;
        }

        private void setupPage_Load(object sender, EventArgs e)
        {

        }
    }
}

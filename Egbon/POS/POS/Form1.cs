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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  string code = (button1.BackColor.ToArgb() & 0x00FFFFFF).ToString("X6");
           // string code = (this.BackColor.ToArgb() & 0x00FFFFFF).ToString("X6");
            POSDataSetTableAdapters.controlsTableAdapter myctrl = new POSDataSetTableAdapters.controlsTableAdapter();
            DataTable mydt = new DataTable();
            mydt = myctrl.GetData();
           // int recCount = mydt.Rows.Count;
            foreach (DataRow row in mydt.Rows)
            {
                
              string ctrlname = row["controlName"].ToString().Trim();
               string ctrltext = row["controlText"].ToString().Trim();
               string ctrlcolor = row["controlCollor"].ToString().Trim();
               string tabname = row["tabName"].ToString().Trim();
               string tabtext = row["tabText"].ToString().Trim();
               string tabcolor = row["tabColor"].ToString().Trim();
              
               Button btn = this.Controls.Find(ctrlname, true).FirstOrDefault() as Button;
               btn.Text = ctrltext;
              // btn.BackColor = (Color)ctrlcolor;
               btn.BackColor = Color.FromName(ctrlcolor);

            }
           this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("HHHHH");
        }

        private void pageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setupPage stpage = new setupPage();
           
            stpage.ShowDialog(this);
        }
    }
}

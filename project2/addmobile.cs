using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class addmobile : Form
    {
        public addmobile()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string modele = textBox1.Text;
            string brand = textBox2.Text;
            string price = textBox3.Text;

            string cs = @"";
        }
    }
}

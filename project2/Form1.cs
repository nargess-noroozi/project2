using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        showmobile showmobile = new showmobile();
        addmobile addmobile = new addmobile();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            showmobile.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addmobile.Show();
        }
    }
}

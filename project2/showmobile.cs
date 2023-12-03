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
    public partial class showmobile : Form
    {
        public showmobile()
        {
            InitializeComponent();
        }

        private void Showmobile_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\source\repos\project2\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();


            string cmd = "SELECT * FROM mobile";

            SqlCommand command = new SqlCommand(cmd, connection);

            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                listBox1.Items.Add(sdr["modele"]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDAM_2_Individual_assignment
{
    public partial class Form1 : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ASUS\\source\\repos\\SDAM - 2 Individual assignment\\inventory.mdf\";Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\SDAM-2 Individual assignment\inventory.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        
        public static int SDAM { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowCount = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "registration";
            cmd.Parameters.Clear();
            con.Open(); // Open the connection before executing the query

            rowCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns a single value

            con.Close(); // Close the connection after executing the query

            MessageBox.Show($"Total rows: {rowCount}");

            
        }

        private void Form_Load_bak(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
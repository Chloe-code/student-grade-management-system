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

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=B;Integrated Security=True ");
        SqlCommand DBCommand;
        SqlDataReader DBReader;
        public Form5()
        {
            InitializeComponent();
            conn.Open();
            DBCommand = new SqlCommand("select * from course1", conn);
            DBReader = DBCommand.ExecuteReader();
            DBReader.Read();
            label2.Text = DBReader["b"].ToString();
            label3.Text = DBReader["c"].ToString();
            label4.Text = DBReader["d"].ToString();
            label5.Text = DBReader["e"].ToString();
            label6.Text = DBReader["f"].ToString();
            label7.Text = DBReader["g"].ToString();
        conn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DBCommand = new SqlCommand("select * from grade", conn);
            DBReader = DBCommand.ExecuteReader();
            DBReader.Read();
            label9.Text = DBReader["b"].ToString();
            label10.Text = DBReader["c"].ToString();
            label11.Text = DBReader["d"].ToString();
            label12.Text = DBReader["e"].ToString();
            label13.Text = DBReader["f"].ToString();
            label14.Text = DBReader["g"].ToString();
            conn.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

    }
}

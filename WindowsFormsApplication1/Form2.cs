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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=B;Integrated Security=True");
        SqlCommand DBCommand;
        Form3 f3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO [B].[dbo].[StudentInfo_1] ([SID],[Name],[Gender],[Birth],[Department],[Address],[Phone])";
            str += "VALUES(@SID,@Name,@Gender,@Birth,@Department,@Address,@Phone)";
            conn.Open();
            DBCommand = new SqlCommand(str, conn);
            DBCommand.Parameters.AddWithValue("@SID", textBox1.Text);
            DBCommand.Parameters.AddWithValue("@Name", textBox2.Text);
            DBCommand.Parameters.AddWithValue("@Gender", textBox3.Text);
            DBCommand.Parameters.AddWithValue("@Birth", textBox4.Text);
            DBCommand.Parameters.AddWithValue("@Department", textBox5.Text);
            DBCommand.Parameters.AddWithValue("@Address", textBox6.Text);
            DBCommand.Parameters.AddWithValue("@Phone", textBox7.Text);
            DBCommand.ExecuteNonQuery();
            conn.Close();
            this.Close();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}

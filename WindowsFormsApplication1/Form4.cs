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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=B;Integrated Security=True");
        SqlCommand DBCommand;
        SqlDataReader DBReader;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "UPDATE [B].[dbo].[StudentInfo_1] SET [SID] = @SID,[Name] = @Name,[Gender] = @Gender,[Birth] = @Birthday,[Department] = @Department,[Address] = @Address,[Phone] = @Phone where [SID] = @SID";
            //str += "where [SID] = @SID";
            conn.Open();
            DBCommand = new SqlCommand(str, conn);
            DBCommand.Parameters.AddWithValue("@SID", textBox1.Text);
            DBCommand.Parameters.AddWithValue("@Name", textBox2.Text);
            DBCommand.Parameters.AddWithValue("@Gender", textBox3.Text);
            DBCommand.Parameters.AddWithValue("@Birthday", textBox4.Text);
            DBCommand.Parameters.AddWithValue("@Department", textBox5.Text);
            DBCommand.Parameters.AddWithValue("@Address", textBox6.Text);
            DBCommand.Parameters.AddWithValue("@Phone", textBox7.Text);
            DBCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = (Form3)this.Owner;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            DBCommand = new SqlCommand("select * from StudentInfo_1 where SID = @SID", conn);
            DBCommand.Parameters.AddWithValue("@SID", textBox1.Text);
            DBReader = DBCommand.ExecuteReader();
            DBReader.Read();
            while (DBReader.HasRows == true)
            {
                textBox1.Text = DBReader["SID"].ToString();
                textBox2.Text = DBReader["Name"].ToString();
                textBox3.Text = DBReader["Gender"].ToString();
                textBox4.Text = DBReader["Birth"].ToString();
                textBox5.Text = DBReader["Department"].ToString();
                textBox6.Text = DBReader["Address"].ToString();
                textBox7.Text = DBReader["Phone"].ToString();
                break;
            }
            conn.Close();
        }
    }
}

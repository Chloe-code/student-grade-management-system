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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=B;Integrated Security=True ");
        SqlCommand DBCommand;
        SqlDataReader DBReader;
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DBCommand = new SqlCommand("select account,password from [login_1] where account = @account", conn);
            DBCommand.Parameters.AddWithValue("@account", textBox1.Text);
            DBReader = DBCommand.ExecuteReader();
            DBReader.Read();
            while (DBReader.HasRows == false)
            { 
                MessageBox.Show("帳號或密碼錯誤");
                break;
            }
            while (DBReader.HasRows == true)
            {
                if (textBox2.Text == DBReader[1].ToString())
                {
                    this.Hide();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
                break;
            }
            conn.Close();
        }
    }
}

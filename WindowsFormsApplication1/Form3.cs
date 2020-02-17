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
    public partial class Form3 : Form
    {
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
       
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=B;Integrated Security=True");
        SqlCommand DBCommand;
        SqlDataReader DBReader;
        public Form3()
        {
            InitializeComponent();
        }

        private void 上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            DBCommand = new SqlCommand("select * from course1", conn);
            DBReader = DBCommand.ExecuteReader();
            DBReader.Read();
            label2.Text = DBReader["a"].ToString();
            label3.Text = DBReader["b"].ToString();
            label4.Text = DBReader["c"].ToString();
            label5.Text = DBReader["d"].ToString();
            label6.Text = DBReader["e"].ToString();
            label7.Text = DBReader["f"].ToString();
            conn.Close();
        }


        private void 電子履歷ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void 下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            DBCommand = new SqlCommand("select * from course2", conn);
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

        private void 畢業初審ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f5.ShowDialog();
        }
    }
}

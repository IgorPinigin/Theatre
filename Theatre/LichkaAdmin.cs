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

namespace Theatre
{
    public partial class LichkaAdmin : Form
    {
        static string filename = " ";
        static string connectionString = "Data Source=DESKTOP-I18PP6U\\SQLEXPRESS;Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public LichkaAdmin()
        {
            InitializeComponent();
        }

        public void save()
        {
            //DateOnly date = dateTimePicker1.Value;
         
            //int vosr = Convert.ToInt32(textBox7.Text);
            //int colvoacts = Convert.ToInt32(textBox8.Text);
            //decimal coaf = Convert.ToDecimal(textBox9.Text);
            connection.Open();
            //SqlCommand sqlCommand1 = new SqlCommand("insert into [Афиша] ([ID], [Название], [Автор])  values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "')", connection);
            SqlCommand cmd = new SqlCommand("insert into [Афиша]  ([ID], [Дата]) VALUES (@id, @value)", connection);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@nazv", textBox2.Text);
            //cmd.Parameters.AddWithValue("@value",date);
            //sqlCommand1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            MessageBox.Show("Файл открыт"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();       
        }
    }
    
}

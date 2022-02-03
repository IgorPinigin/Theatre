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
    public partial class Registration : Form
    {
        static string connectionString = "Data Source=DESKTOP-I18PP6U\\SQLEXPRESS;Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public Registration()
        {
            InitializeComponent();
        }

        public void registrations()
        {
            connection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("insert into [Данные авторизации] ([Логин] ,[Пароль]) values ('" + textBox1.Text + "','" + textBox6.Text + "')", connection);
            sqlCommand1.ExecuteNonQuery();
            SqlCommand sqlCommand2 = new SqlCommand("insert into [Пользователи] ([Логин] ,[Имя], [Отчество], [Фамилия] , [Почта]) values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", connection);
            sqlCommand2.ExecuteNonQuery();              
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (textBox2.Text == "") 
            { 
                MessageBox.Show("Введите имя");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введите отчество");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Введите почту");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            registrations();

        }
    }
}

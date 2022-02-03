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
    public partial class Popolnenie : Form
    {
        static string connectionString = "Data Source=DESKTOP-I18PP6U\\SQLEXPRESS;Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public Popolnenie()
        {
            InitializeComponent();
        }

        private void Popolnenie_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sqlExpression = "SELECT * FROM [Пользователи] where [Логин] = '" + Login.loginkrutoi228 + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    while (reader.Read())
                    {
                        int c = reader.GetInt32(5);
                        string b = Convert.ToString(c);
                        label2.Text = b;  

                    }
                }

                reader.Close();
            }

            Console.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            SqlCommand sqlCommand1 = new SqlCommand("update [Пользователи] set [Баланс] = [Баланс] +'" + a + "' where [Логин] =  '" + Login.loginkrutoi228 + "'", connection);
            sqlCommand1.ExecuteNonQuery();
        }
    }
}

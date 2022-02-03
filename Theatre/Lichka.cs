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
    public partial class Lichka : Form
    {
        static string connectionString = "Data Source=DESKTOP-I18PP6U\\SQLEXPRESS;Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public Lichka()
        {
            InitializeComponent();
        }

        private void Lichka_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sqlExpression1 = "SELECT * FROM [Пользователи] where [Логин] = '" + Login.loginkrutoi228 + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    while (reader.Read())
                    {
                        label3.Text = (reader.GetString(0));
                        
                    }
                }

                reader.Close();
                
            }
            
            Console.Read();
            
            string sqlExpression2 = "SELECT * FROM [Пользователи] where [Логин] = '" + Login.loginkrutoi228 + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression2, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    while (reader.Read())
                    {
                        int c = reader.GetInt32(5);
                        string b = Convert.ToString(c);
                        label5.Text = b;

                    }
                }

                reader.Close();
            }

            Console.Read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login newForm = new Login();
            newForm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AccInfo newForm = new AccInfo();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Afisha newForm = new Afisha();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Popolnenie newForm = new Popolnenie();
            newForm.Show();
        }
    }
}

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
    public partial class AccInfo : Form
    {
        static string connectionString = "Data Source=DESKTOP-I18PP6U\\SQLEXPRESS;Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

       
            //connection.Open();
            //SqlCommand sqlCommand = new SqlCommand("select  from  where username = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'", connection);
        
        public AccInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Lichka newForm = new Lichka();
            newForm.Show(); 
        }

        private void AccInfo_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sqlExpression = "SELECT * FROM [Пользователи] where [Логин] = '"+Login.loginkrutoi228+"'";
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
                        label1.Text = (reader.GetString(1));
                        label2.Text = (reader.GetString(2));
                        label3.Text = (reader.GetString(3));
                        label4.Text = (reader.GetString(4));
                    }
                }

                reader.Close();
            }

            Console.Read();
        }
    }
}

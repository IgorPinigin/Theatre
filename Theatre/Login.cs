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
    public partial class Login : Form
    {
        
        static string connectionString = "Data Source=DESKTOP-I18PP6U\\SQLEXPRESS;Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        static public string loginkrutoi228 = "BIRUK BOMJ SSANIY";
        public int a = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public int countLogins( )
        {
            int newProdID = 0;
            string sql = "select count(*)from [Данные авторизации] where [Логин] = '" +textBox1.Text + "' and [Пароль] = '" + textBox2.Text + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    newProdID = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            connection.Close();
            //MessageBox.Show(newProdID.ToString());
            return (int)newProdID;
        }


        public void logins()
        {
            connection.Open();
            string sqlCommand = "select [Администратор] from [Данные авторизации] where [Логин] = '" + textBox1.Text + "' and [Пароль] = '" + textBox2.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionString));
            
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                
                while (reader.Read())
                {
                    if (reader.GetBoolean(0) == true)
                        a = 1;
                }
            }
            int c = countLogins() + a;
            if (c == 1)
            {
                loginkrutoi228 = textBox1.Text;
                Lichka newForm = new Lichka();
                newForm.Show();
                this.Close();

            }
            else
                if (c == 2)
            {
                loginkrutoi228 = textBox1.Text;
                LichkaAdmin newForm = new LichkaAdmin();
                newForm.Show();
                this.Close();
            }
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
                MessageBox.Show("Введите пароль");
                return;
            }

            logins();
            
        }
    }
}

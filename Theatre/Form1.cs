using System.Data.SqlClient;

namespace Theatre
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            //this.Visible = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            //this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
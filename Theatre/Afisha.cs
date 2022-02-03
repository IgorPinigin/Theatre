using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theatre
{
    public partial class Afisha : Form
    {
        public Afisha()
        {
            //pictureBox1.ImageLocation = ("C\\Users\\Игорь\\Desktop\\mine\\src\\main\\resources\\assets\\igor228mod\\textures\\items\\unknown.png");
            InitializeComponent();
           
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lichka newForm = new Lichka();
            newForm.Show();
            this.Close();
        }

        private void Afisha_Load(object sender, EventArgs e)
        { 
            pictureBox1.ImageLocation = ("C\\Users\\Игорь\\Desktop\\mine\\src\\main\\resources\\assets\\igor228mod\\textures\\items\\unknown.png");     
        }
        
        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png" })
        //    {
        //        if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            (sender as PictureBox).Load(ofd.FileName);
        //        }
        //    }
        //}
    }
}

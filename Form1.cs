using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        frmAnasayfa frmAnasayfa=new frmAnasayfa();  
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "sekerbasak" && textBox2.Text == "123")
            {
                this.Hide();
                frmAnasayfa.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre hatalı tekrar deneyiniz..");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}

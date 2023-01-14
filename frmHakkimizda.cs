using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmHakkimizda : Form
    {
        public frmHakkimizda()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=dbPansiyonKayit; user Id=postgres; password=Basak.123");

        private void frmHakkimizda_Load(object sender, EventArgs e)
        {
            if (baglan!=null)
            {
                MessageBox.Show("Veritabanına bağlanıldı");

            }
            else
            {
                MessageBox.Show("Veritabanına bağlanılamadı");

            }
            string sorgu = "select *from \"pansiyonKayitSchemas\".hakkimizdalistele()";
            string deger;
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglan);
            baglan.Open();
            deger = (string)komut.ExecuteScalar();
             label1.Text = deger;


            string sorgu2= "select \"Ad\" from \"pansiyonKayitSchemas\".tbliller where \"Ad\"='Sakarya'";
            string deger2;
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglan);   
            deger2= (string)komut2.ExecuteScalar();
            label3.Text = deger2;
            baglan.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnasayfa frmAnasayfa = new frmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

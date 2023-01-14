using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmAnasayfa frmAnasayfa = new frmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=dbPansiyonKayit; user Id=postgres; password=Basak.123");
        private void frmOdalar_Load(object sender, EventArgs e)
        {
            if (baglan != null)
            {
                MessageBox.Show("Veritabanına bağlanıldı");

            }
            else
            {
                MessageBox.Show("Veritabanına bağlanılamadı");
            }

            string sorgu= "select \"pansiyonKayitSchemas\".\"tblOdaNo\".\"ODaNo\" AS OdaID,\"KatNo\",\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\",\r\n\"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipi\",\"pansiyonKayitSchemas\".\"tblOdaTip\".\"GunlukUcret\"from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"\r\ninner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\"ORDER BY \"OdaID\" ASC; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglan);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            string sorgu2 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=1";
            string deger2;
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglan);
            baglan.Open();
            deger2 = (string)komut2.ExecuteScalar();
            label4.Text = deger2;
            if (label4.Text == "Dolu")
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.Green;

            }

            string sorgu3 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=2";
            string deger3;
            NpgsqlCommand komut3 = new NpgsqlCommand(sorgu3, baglan);
            
            deger3 = (string)komut3.ExecuteScalar();
            label4.Text = deger3;
            if (label4.Text == "Dolu")
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.BackColor = Color.Green;

            }


            string sorgu4 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=3";
            string deger4;
            NpgsqlCommand komut4 = new NpgsqlCommand(sorgu4, baglan);
            
            deger4 = (string)komut4.ExecuteScalar();
            label4.Text = deger4;
            if (label4.Text == "Dolu")
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.BackColor = Color.Green;

            }


            string sorgu5 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=4";
            string deger5;
            NpgsqlCommand komut5 = new NpgsqlCommand(sorgu5, baglan);

            deger5 = (string)komut5.ExecuteScalar();
            label4.Text = deger5;
            if (label4.Text == "Dolu")
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.Green;

            }



            string sorgu6 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=5";
            string deger6;
            NpgsqlCommand komut6 = new NpgsqlCommand(sorgu6, baglan);

            deger6= (string)komut6.ExecuteScalar();
            label4.Text = deger6;
            if (label4.Text == "Dolu")
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.Green;

            }


            string sorgu7 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=6";
            string deger7;
            NpgsqlCommand komut7 = new NpgsqlCommand(sorgu7, baglan);

            deger7 = (string)komut7.ExecuteScalar();
            label4.Text = deger7;
            if (label4.Text == "Dolu")
            {
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.BackColor = Color.Green;

            }




            string sorgu8 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=7";
            string deger8;
            NpgsqlCommand komut8 = new NpgsqlCommand(sorgu8, baglan);

            deger8 = (string)komut8.ExecuteScalar();
            label4.Text = deger8;
            if (label4.Text == "Dolu")
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.Green;

            }


            string sorgu9 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=8";
            string deger9;
            NpgsqlCommand komut9 = new NpgsqlCommand(sorgu9, baglan);

            deger9 = (string)komut9.ExecuteScalar();
            label4.Text = deger9;
            if (label4.Text == "Dolu")
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.BackColor = Color.Green;

            }




            string sorgu10 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=9";
            string deger10;
            NpgsqlCommand komut10 = new NpgsqlCommand(sorgu10, baglan);

            deger10 = (string)komut10.ExecuteScalar();
            label4.Text = deger10;
            if (label4.Text == "Dolu")
            {
                button10.BackColor = Color.Red;
            }
            else
            {
                button10.BackColor = Color.Green;

            }


            string sorgu12 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=10";
            string deger12;
            NpgsqlCommand komut12 = new NpgsqlCommand(sorgu12, baglan);

            deger12 = (string)komut12.ExecuteScalar();
            label4.Text = deger12;
            if (label4.Text == "Dolu")
            {
                button12.BackColor = Color.Red;
            }
            else
            {
                button12.BackColor = Color.Green;

            }




            string sorgu13 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=11";
            string deger13;
            NpgsqlCommand komut13 = new NpgsqlCommand(sorgu13, baglan);

            deger13 = (string)komut13.ExecuteScalar();
            label4.Text = deger13;
            if (label4.Text == "Dolu")
            {
                button13.BackColor = Color.Red;
            }
            else
            {
                button13.BackColor = Color.Green;

            }


            string sorgu14 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=12";
            string deger14;
            NpgsqlCommand komut14 = new NpgsqlCommand(sorgu14, baglan);

            deger14 = (string)komut14.ExecuteScalar();
            label4.Text = deger14;
            if (label4.Text == "Dolu")
            {
                button14.BackColor = Color.Red;
            }
            else
            {
                button14.BackColor = Color.Green;

            }





            baglan.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}

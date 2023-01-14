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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=dbPansiyonKayit; user Id=postgres; password=Basak.123");
        private void button2_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "1";
            button2.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "2";
            button3.BackColor = Color.Red;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "3";
            button4.BackColor = Color.Red;
            button3.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "4";
            button5.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "5";
            button6.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "6";
            button7.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button2.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "7";
            button8.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button2.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "8";
            button9.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button2.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "9";
            button10.BackColor =Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button2.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            txtGunlukUcret.Text = "100";

        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir..");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir..");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button2.Enabled = true;
            button10.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"pansiyonKayitSchemas\".\"tblMusteri1\" (\"KisiID\",\"Ad\",\"Soyad\",\"Mail\",\"CinsiyetID\",\"TC\",\"OdaNo\",\"GirisTarihi\",\"CikisTarihi\",\"HesapTutari\") values(@p1,@p2,@p3,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglan);
           
            
            komut.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
          //  komut.Parameters.AddWithValue("@p4", int.Parse(maskedTextBox1.Text));
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            int cinsiyet = 0;
            if(radioButton1.Checked)
            cinsiyet = 1;
            else if (radioButton2.Checked)
            cinsiyet = 2;
            komut.Parameters.AddWithValue("@p6", cinsiyet);
            komut.Parameters.AddWithValue("@p7", Convert.ToInt64(txtTC.Text));
            komut.Parameters.AddWithValue("@p8", int.Parse(txtOdaNo.Text));
           // komut.Parameters.AddWithValue("@p9", txtGunlukUcret.Text);
            komut.Parameters.AddWithValue("@p9", Convert.ToDateTime( dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@p10", Convert.ToDateTime(dateTimePicker2.Text));
            komut.Parameters.AddWithValue("@p11", int.Parse(txtHesapTutarı.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi!","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            

           

        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmAnasayfa frmAnasayfa = new frmAnasayfa();

            frmAnasayfa.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {    baglan.Open();
            string sorgu2 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=1";
            string deger2;
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglan);
            
            deger2 = (string)komut2.ExecuteScalar();
            label16.Text = deger2;
            if (label16.Text == "Dolu")
            {
                button2.BackColor = Color.Red;
                button2.Enabled=false;
            }
            else
            {
                button2.BackColor = Color.Green;

            }

            string sorgu3 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=2";
            string deger3;
            NpgsqlCommand komut3 = new NpgsqlCommand(sorgu3, baglan);

            deger3 = (string)komut3.ExecuteScalar();
            label16.Text = deger3;
            if (label16.Text == "Dolu")
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            else
            {
                button3.BackColor = Color.Green;

            }


            string sorgu4 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=3";
            string deger4;
            NpgsqlCommand komut4 = new NpgsqlCommand(sorgu4, baglan);

            deger4 = (string)komut4.ExecuteScalar();
            label16.Text = deger4;
            if (label16.Text == "Dolu")
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            else
            {
                button4.BackColor = Color.Green;

            }


            string sorgu5 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=4";
            string deger5;
            NpgsqlCommand komut5 = new NpgsqlCommand(sorgu5, baglan);

            deger5 = (string)komut5.ExecuteScalar();
            label16.Text = deger5;
            if (label16.Text == "Dolu")
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            else
            {
                button5.BackColor = Color.Green;

            }



            string sorgu6 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=5";
            string deger6;
            NpgsqlCommand komut6 = new NpgsqlCommand(sorgu6, baglan);

            deger6 = (string)komut6.ExecuteScalar();
            label16.Text = deger6;
            if (label16.Text == "Dolu")
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            else
            {
                button6.BackColor = Color.Green;

            }


            string sorgu7 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=6";
            string deger7;
            NpgsqlCommand komut7 = new NpgsqlCommand(sorgu7, baglan);

            deger7 = (string)komut7.ExecuteScalar();
            label16.Text = deger7;
            if (label16.Text == "Dolu")
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            else
            {
                button7.BackColor = Color.Green;

            }




            string sorgu8 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=7";
            string deger8;
            NpgsqlCommand komut8 = new NpgsqlCommand(sorgu8, baglan);

            deger8 = (string)komut8.ExecuteScalar();
            label16.Text = deger8;
            if (label16.Text == "Dolu")
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            else
            {
                button8.BackColor = Color.Green;

            }


            string sorgu9 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=8";
            string deger9;
            NpgsqlCommand komut9 = new NpgsqlCommand(sorgu9, baglan);

            deger9 = (string)komut9.ExecuteScalar();
            label16.Text = deger9;
            if (label16.Text == "Dolu")
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
            else
            {
                button9.BackColor = Color.Green;

            }




            string sorgu10 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=9";
            string deger10;
            NpgsqlCommand komut10 = new NpgsqlCommand(sorgu10, baglan);

            deger10 = (string)komut10.ExecuteScalar();
            label16.Text = deger10;
            if (label16.Text == "Dolu")
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
            else
            {
                button10.BackColor = Color.Green;

            }


            string sorgu12 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=10";
            string deger12;
            NpgsqlCommand komut12 = new NpgsqlCommand(sorgu12, baglan);

            deger12 = (string)komut12.ExecuteScalar();
            label16.Text = deger12;
            if (label16.Text == "Dolu")
            {
                button12.BackColor = Color.Red;
                button12.Enabled = false;
            }
            else
            {
                button12.BackColor = Color.Green;

            }




            string sorgu13 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=11";
            string deger13;
            NpgsqlCommand komut13 = new NpgsqlCommand(sorgu13, baglan);

            deger13 = (string)komut13.ExecuteScalar();
            label16.Text = deger13;
            if (label16.Text == "Dolu")
            {
                button13.BackColor = Color.Red;
                button13.Enabled = false;
            }
            else
            {
                button13.BackColor = Color.Green;

            }


            string sorgu14 = " select \"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumu\" from \"pansiyonKayitSchemas\".\"tblOdalar\"inner join \"pansiyonKayitSchemas\".\"tblOdaNo\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaID\"=\"pansiyonKayitSchemas\".\"tblOdaNo\".\"OdaNoID\" inner join \"pansiyonKayitSchemas\".\"tblOdaDurumu\" on  \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaDurumuID\"=\"pansiyonKayitSchemas\".\"tblOdaDurumu\".\"OdaDurumID\"inner join \"pansiyonKayitSchemas\".\"tblOdaTip\" ON \"pansiyonKayitSchemas\".\"tblOdaTip\".\"OdaTipID\" = \"pansiyonKayitSchemas\".\"tblOdalar\".\"OdaTipID\" where \"tblOdaNo\".\"OdaNoID\"=12";
            string deger14;
            NpgsqlCommand komut14 = new NpgsqlCommand(sorgu14, baglan);

            deger14 = (string)komut14.ExecuteScalar();
            label16.Text = deger14;
            if (label16.Text == "Dolu")
            {
                button14.BackColor = Color.Red;
                button14.Enabled = false;
            }
            else
            {
                button14.BackColor = Color.Green;

            }





            baglan.Close();




        }
        private void button12_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "10";
            button12.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button2.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button10.Enabled= false;
            txtGunlukUcret.Text = "200";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "11";
            button13.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button2.Enabled = false;
            button12.Enabled = false;
            button14.Enabled = false;
            button10.Enabled = false;
            txtGunlukUcret.Text = "200";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "12";
            button14.BackColor = Color.Red;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button2.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button10.Enabled = false;
            txtGunlukUcret.Text = "200";

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           /* if (txtOdaNo.Text == "401" || txtOdaNo.Text == "402" || txtOdaNo.Text == "403")
            {
                int GunlukUcret = 200;

                DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime BuyukTarih = Convert.ToDateTime(dateTimePicker2.Text);
                TimeSpan sonuc;
                sonuc = (BuyukTarih - KucukTarih);
                label16.Text = sonuc.TotalDays.ToString();
                int Sonuc = Convert.ToInt32(label6.Text);
                txtHesapTutarı.Text =(Sonuc*GunlukUcret).ToString();
            }
            else
            {
                int GunlukUcret = 100;

                DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime BuyukTarih = Convert.ToDateTime(dateTimePicker2.Text);
                TimeSpan sonuc;
                sonuc = (BuyukTarih - KucukTarih);
                label16.Text = sonuc.TotalDays.ToString();
                int Sonuc = Convert.ToInt32(label6.Text);
                txtHesapTutarı.Text =( Sonuc*GunlukUcret).ToString();

            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmMusteriList : Form
    {
        public frmMusteriList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmAnasayfa frmAnasayfa = new frmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
        NpgsqlConnection baglan=new NpgsqlConnection("server=localHost; port=5432; Database=dbPansiyonKayit; user Id=postgres; password=Basak.123");
        private void CinsiyetleriCek()
        {
            //CİNSİYETLERİ RADİOBUTTONA YAZDIRMA
            baglan.Open();
            string sorgu = "SELECT \"Cinsiyet\" FROM \"pansiyonKayitSchemas\".\"tblCinsiyet\" where \"CinsiyetID\"=1 ";
            string deger;
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglan);
            deger = (string)cmd.ExecuteScalar();
            radioButton1.Text = deger;
            string sorgu2 = "SELECT \"Cinsiyet\" FROM \"pansiyonKayitSchemas\".\"tblCinsiyet\" where \"CinsiyetID\"=2 ";
            string deger2;
            NpgsqlCommand cmd2 = new NpgsqlCommand(sorgu2, baglan);

            deger2 = (string)cmd2.ExecuteScalar();
            radioButton2.Text = deger2;
            baglan.Close();
        }
        private void frmMusteriList_Load(object sender, EventArgs e)
        {
            CinsiyetleriCek();
            baglan.Open();
            if (baglan != null)
            {
                MessageBox.Show("Veritabanına bağlanıldı");

            }
            else
            {
                MessageBox.Show("Veritabanına bağlanılamadı");
            }

            string sorgu = "SELECT * FROM \"pansiyonKayitSchemas\".\"tblMusteri1\" ORDER BY \"KisiID\" ASC ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            string sorgu2 = "select * from \"pansiyonKayitSchemas\".musterisayisi()";
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglan);
            NpgsqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                label18.Text = dr.GetValue(0).ToString();
            }


            baglan.Close();



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //MÜŞTERİ SİLME
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from \"pansiyonKayitSchemas\".\"tblMusteri1\" where \"KisiID\"=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Müşteri Kaydı Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from \"pansiyonKayitSchemas\".\"tblMusteri1\" where \"Ad\" like'%" + textBox6.Text + "%'", baglan);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string MusteriID = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string Ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Telefon = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Email = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string Cinsiyet = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string TC = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string OdaNO = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string GirisTarihi = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string CikisTarihi = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();
            string HesapTutari = dataGridView1.Rows[secilialan].Cells[10].Value.ToString();
         
            textBox1.Text = MusteriID;
            textBox2.Text = Ad;
            textBox9.Text = Soyad;
            textBox3.Text = Telefon;
            textBox5.Text = Email;
            textBox7.Text = TC;
            textBox8.Text = OdaNO;
            textBox4.Text = HesapTutari;
            if (Cinsiyet == "1")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            dateTimePicker1.Text = GirisTarihi;
            dateTimePicker2.Text = CikisTarihi;
            
        }
    }
}

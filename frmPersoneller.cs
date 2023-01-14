using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=dbPansiyonKayit; user Id=postgres; password=Basak.123");

        private void button11_Click(object sender, EventArgs e)
        {
            frmAnasayfa frmAnasayfa = new frmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {

            baglan.Open();
            string sorgu = "SELECT * FROM \"pansiyonKayitSchemas\".\"tblPersonel1\" ORDER BY \"KisiID\" ASC ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            string sorgu2 = "select * from \"pansiyonKayitSchemas\".personelsayisi()";
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglan);
            NpgsqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                label16.Text = dr.GetValue(0).ToString();
            }

            baglan.Close();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //PERSONEL GÜNCELLEME
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update \"pansiyonKayitSchemas\".\"tblPersonel1\" set  \"Ad\"=@p2,\"Soyad\"=@p3,\"Mail\"=@p5,\"TC\"=@p6,\"DepartmanID\"=@p7,\"Maas\"=@p8 where \"KisiID\"=@p1  ", baglan);
            komut.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));//kişiId
            komut.Parameters.AddWithValue("@p2", textBox2.Text);//ad
            komut.Parameters.AddWithValue("@p3", textBox4.Text);//soyad
          //  komut.Parameters.AddWithValue("@p4", Convert.ToUInt32(textBox3.Text));//telefon
            komut.Parameters.AddWithValue("@p5", textBox5.Text);//email
            string cinsiyet;
            if(radioButton1.Text=="Kadın")
            cinsiyet = radioButton1.Text;
            else
            cinsiyet = radioButton2.Text;
            komut.Parameters.AddWithValue("@p6", Convert.ToInt64(textBox7.Text));
            komut.Parameters.AddWithValue("@p7", int.Parse(textBox8.Text));
            komut.Parameters.AddWithValue("@p8", int.Parse(textBox10.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Personel Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //PERSONEL SİLME
           baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from \"pansiyonKayitSchemas\".\"tblPersonel1\" where \"KisiID\"=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Personel Kaydı Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop); 

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string PersonelID = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string Ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Telefon = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Email = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string Cinsiyet = dataGridView1.Rows[secilialan ].Cells[5].Value.ToString();
            string TC = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string Departman = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string Maas = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();

            textBox1.Text = PersonelID;
            textBox2.Text = Ad;
            textBox4.Text = Soyad;
            textBox3.Text = Telefon;
            textBox5.Text = Email;
            textBox7.Text = TC;
            textBox8.Text = Departman;
            if (Cinsiyet=="1")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox10.Text = Maas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PERSONEL ARAMA
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from \"pansiyonKayitSchemas\".\"tblPersonel1\" where \"Ad\" like'%" + textBox6.Text + "%'", baglan);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
    }
}

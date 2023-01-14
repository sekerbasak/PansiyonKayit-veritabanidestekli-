using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox5.Text = textBox5.Text.Substring(1) + textBox5.Text.Substring(0, 1);

        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
       frmMusteriEkle frmMusteriEklee=new frmMusteriEkle();
        private void button6_Click(object sender, EventArgs e)
        { 
           frmMusteriEklee.Show();
            this.Hide();
           
        }
        frmOdalar frmOdalar= new frmOdalar();   
        private void button1_Click(object sender, EventArgs e)
        {
            frmOdalar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPersoneller frmPersoneller = new frmPersoneller();   
            frmPersoneller.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriList frmMusteriList = new frmMusteriList();
            frmMusteriList.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmHakkimizda frmHakkimizda = new frmHakkimizda();
            frmHakkimizda.Show();
            this.Hide();

        }

        private void button_Click(object sender, EventArgs e)
        {
            frmResimler frmResimler = new frmResimler();
            frmResimler.Show();
            this.Hide();
        }
    }
}

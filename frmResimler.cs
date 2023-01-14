using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmResimler : Form
    {
        public frmResimler()
        {
            InitializeComponent();
        }

        private void frmResimler_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmAnasayfa frmAnasayfa = new frmAnasayfa();
            this.Hide();
            frmAnasayfa.Show();
        }
    }
}

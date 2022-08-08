using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOK
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eSTOKDataSet6.UKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uKayitTableAdapter.Fill(this.eSTOKDataSet6.UKayit);

        }

        private void DtStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSAz_Click(object sender, EventArgs e)
        {

        }

        private void btnSAz_Click_1(object sender, EventArgs e)
        {
            AzStokGetir AzStokGetir = new AzStokGetir();
            AzStokGetir.Show();



            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

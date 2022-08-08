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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eSTOKDataSet5.UKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uKayitTableAdapter1.Fill(this.eSTOKDataSet5.UKayit);
            // TODO: Bu kod satırı 'eSTOKDataSet4.UKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uKayitTableAdapter.Fill(this.eSTOKDataSet4.UKayit);
    

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

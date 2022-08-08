using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace STOK
{
    public partial class AzStokGetir : Form
    {
        private object dAdapter;

        public AzStokGetir()
        {
            InitializeComponent();
        }

        private void AzStokGetir_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-1MCSHOR;Initial Catalog=ESTOK;Integrated Security=True");



            DataTable dTable = new DataTable();
            this.uKayitTableAdapter.Fill(this.eSTOKDataSet7.UKayit);
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM  UKayit WHERE Adet<5 ", Con))
         
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;
            label1.Text = "STOK ADETİ 10 UN ALTINDA OLANLAR GOSTERILIYOR";

            // TODO: Bu kod satırı 'eSTOKDataSet7.UKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

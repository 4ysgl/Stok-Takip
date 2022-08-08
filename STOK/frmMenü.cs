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


namespace STOK
{
    public partial class frmMenü : Form
    {
        public frmMenü()
        {
            InitializeComponent();
        }

        SqlConnection Con;
        SqlDataAdapter Da;
        DataSet Ds= new DataSet();
        SqlCommandBuilder Cmd;
        private void button4_Click(object sender, EventArgs e)
        {

            frmUlas frmUlas = new frmUlas();

            frmUlas.Show();
           

        }

        private void button1_Click(object sender, EventArgs e)
        { // Ürün İşlemlerı

            frmKyt frmÜrünİslem = new frmKyt();

            frmÜrünİslem.Show();

            


        }

        private void btnStokTakip_Click(object sender, EventArgs e)
        {
            Stok Stok = new Stok();
            Stok.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris GAc = new frmGiris();
            GAc.Show();
        }

        private void frmMenü_Load(object sender, EventArgs e)
        {

        }
    }
}

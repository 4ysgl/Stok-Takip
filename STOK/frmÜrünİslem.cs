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
    public partial class frmKyt : Form
    {
        public frmKyt()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-1MCSHOR;Initial Catalog=ESTOK;Integrated Security=True");

        SqlCommand Cmd; // verı cekmek ıcın kullanacagımız t-sql kodlarının komutu

        SqlDataReader Dr; //yazılan komutun calıstırılınca donen degerını okumaya yarar 



        // Verı tabanımızdakı verılerı cekmek ıcın
        // sunucudan verı tabanına baglanmamızı saglayan yol.



        // SqlCommand Cmd; // verı cekmek ıcın kullanacagımız t-sql kodlarının komutu




        public void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.


                string kayit = "insert into UKayit(UrunAdi,Kategori,Adet,Stt,UrunBilgi) values (@UAdi,@Kategori,@Adet,@Stt,@UBilgi)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand Cmd = new SqlCommand(kayit, Con); //  cmd komutunun ıcerısıne baglantıyı ve t-sql komutunu atıyoruz



              

                //Cmd.CommandText= "insert into UrunKayit(UrunKodu,UrunAdi,Kategori,Stt,UrunBilgi) values (@UKodu,@UAdi,@Kategori,@Stt,@UBilgi)";
                //// müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.

                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.

                Cmd.Parameters.AddWithValue("@UAdi", txtÜrünİsim.Text);
                Cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text);
                Cmd.Parameters.AddWithValue("@Adet", txtAdet.Text);
                Cmd.Parameters.AddWithValue("@Stt", txtStt.Text);

                Cmd.Parameters.AddWithValue("@UBilgi", txtÜrünBilgi.Text);

             
                Cmd.ExecuteReader();
              
                
                MessageBox.Show("Ürün Kayıt İşlemi Gerçekleşti.");
                Con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }




        }

        public void frmÜrünİslem_Load(object sender, EventArgs e)
        {

        }

        public void btnDelete_Click(object sender, EventArgs e) //DELETE ISLEMI
        {


            if (MessageBox.Show("Silme İşlemini onaylıyormusunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Con.Open();

                string silmeSorgusu = "DELETE from UKayit  where UrunAdi=@UAdi";

                //Urun Adı  parametresine bağlı olarak müşteri kaydını silen sql sorgusu
                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, Con);
                silKomutu.Parameters.AddWithValue("@UAdi", txtÜrünİsim.Text);
                string versorgu = "select * from UKayit  where UrunAdi='" + txtÜrünİsim.Text + "'";

                silKomutu.ExecuteNonQuery();


                Con.Close();
            }
            else
{
                MessageBox.Show("Silme işlemi tarafınızca iptal edilmiştir.");
            }





          




            //Con.Open();


            //string silmeSorgusu = "DELETE from UKayit  where UrunAdi=@UAdi";

            ////musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
            //SqlCommand silKomutu = new SqlCommand(silmeSorgusu, Con);
            //silKomutu.Parameters.AddWithValue("@UAdi", txtÜrünİsim.Text);
            //string versorgu = "select * from UKayit  where UrunAdi='" + txtÜrünİsim.Text + "'";

            //silKomutu.ExecuteNonQuery();


            //Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //  DEPODAKI URUNLERI LISTELE
        private void button1_Click(object sender, EventArgs e)
        {
            Listele Listele = new Listele();
            Listele.Show();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
    

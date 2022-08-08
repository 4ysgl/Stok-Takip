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

   // 
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-1MCSHOR;Initial Catalog=ESTOK;Integrated Security=True");
        
        
      
        
        
        SqlCommand Cmd; 
        
        SqlDataReader Dr;
   

        private void button1_Click(object sender, EventArgs e)
            // gırıs butanını aktıf edıp butona tıkladıgımızda 
          //  gerceklesmesını ıstedıgımız komutları içine yazıyoruz 
       {

            string ad = txtAd.Text; 
            string sifre = txtSifre.Text;

            Cmd = new SqlCommand(); 
            Con.Open();
            Cmd.Connection = Con; //Baglantı adresımızı cmd komutunun ıcıne atıyoruz kı daha sonra
            //komutu calısıtırken aynı anda baglantı da olussun

            Cmd.CommandText = "SELECT * FROM Kullanıcı where KullanıcıAdı='" + txtAd.Text + "' AND Sifre='" + txtSifre.Text + "'";
            //Ustte verı tabanından hangı alanların 
            //kontrolunu yapmak ıstıyorsak onları belırtıyoruz.


            Dr = Cmd.ExecuteReader(); //Komutu calıstırıyoruz

            if (Dr.Read()) // Eger gırılen bılgıler sql dekı verılerle uyusuyorsa bızı 
                //2. asama olan menu kısmına yonlerdırecek
            {
                 frmMenü frmMenü = new frmMenü();

                 frmMenü.Show();
     
            }
            else
            {

                // KOsulun saglanmaması durumunda kullanıcıyı uyarıyoruz
                MessageBox.Show(" KULLANICI ADI VEYA /VE ŞİFRE YANLIŞ !!"); 
            }

            //this.Hide(); //Kullanıcı giris formunu gizliyoruz
            Dr.Close(); //verı okuma ıslemı tamamlanınca kapatıyoruz (SQLDATAREADER)
            Con.Close(); // Baglantıyı kapatıyoruz


            



        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

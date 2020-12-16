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

namespace KantarUYgulamasi
{

    public partial class FmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VUJJUC7E\\SQLEXPRESS;Initial Catalog=kantar;Integrated Security=True");
        SqlCommand kkomut;
        SqlCommand rkomut;
       
        int agirlik = 0;
       
      
        public FmGiris()
        {
            InitializeComponent();
           

        }
       
        private void Btnkayit_Click_1(object sender, EventArgs e)
        {
          
        
            
            try
            {

                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }




                kkomut = new SqlCommand("INSERT INTO kamyon(Plaka, Sofor, Kayit_Eden,Giris_Agirlik) VALUES(@plaka,@sofor,@kayit_eden,@agirlik)", baglanti);
                rkomut = new SqlCommand("INSERT INTO rapor(Plaka, Sofor, Kayit_Eden,Giris_Agirlik) VALUES(@plaka1,@sofor1,@kayit_eden1,@agirlik1)", baglanti);
                kkomut.Parameters.AddWithValue("@plaka", textBox1.Text);
                kkomut.Parameters.AddWithValue("@sofor", textBox2.Text);
                kkomut.Parameters.AddWithValue("@kayit_eden", textBox4.Text);
                kkomut.Parameters.AddWithValue("@agirlik",agirlik);
                rkomut.Parameters.AddWithValue("@plaka1", textBox1.Text);
                rkomut.Parameters.AddWithValue("@sofor1", textBox2.Text);
                rkomut.Parameters.AddWithValue("@kayit_eden1", textBox4.Text);
                rkomut.Parameters.AddWithValue("@agirlik1", agirlik);



                kkomut.ExecuteNonQuery();
                rkomut.ExecuteNonQuery();             
                baglanti.Close();
                MessageBox.Show(" Kayıt Eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Eklenemedi!" + hata.Message);
            }
            FmGiris frm = new FmGiris();
            this.Hide();

        }


            private void cikis_Click(object sender, EventArgs e)
        {
           
        }

        private void FmGiris_Load(object sender, EventArgs e)
        {

        }

        private void Btnkayit_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void rapor_Click(object sender, EventArgs e)
        {
            FmRapor frm = new FmRapor();
            frm.Show();
            this.Hide();
        }

        
    }
}

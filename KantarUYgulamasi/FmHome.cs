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
    public partial class FmHome : Form
    {
        public FmHome()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VUJJUC7E\\SQLEXPRESS;Initial Catalog=kantar;Integrated Security=True");
        
        void guncelle()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            da = new SqlDataAdapter("Select *From kamyon", baglanti);
            ds = new DataSet();
            da.Fill(ds, "kamyon");
            dataGridView1.DataSource = ds.Tables["kamyon"];
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        
       

        private void FmHome_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kantarDataSet111.kamyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kamyonTableAdapter6.Fill(this.kantarDataSet111.kamyon);
            // TODO: Bu kod satırı 'kantarDataSet10.kamyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kamyonTableAdapter5.Fill(this.kantarDataSet10.kamyon);
       
            griddoldur();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void giriss_Click(object sender, EventArgs e)
        {
            FmGiris frm = new FmGiris();
            frm.Show();
        }

        private void cikiss_Click(object sender, EventArgs e)
        {
            FmCikis frm = new FmCikis();
            frm.Show();
        }

        SqlDataAdapter da;
        DataSet ds;
      
        SqlCommand komut3;
        SqlCommand komut4;
        SqlCommand ekle;
        SqlCommand yukfarki;
        SqlCommand komut6;
        SqlCommand komut5;
       
        int YukFark = 0;
        int girisagirlik = 0;
        void griddoldur()
        {
           
            da = new SqlDataAdapter("Select *From kamyon", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kamyon");
            dataGridView1.DataSource = ds.Tables["kamyon"];
            baglanti.Close();
        }

        void KayıtSil(string remId)
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }

            string sql = "DELETE FROM kamyon WHERE id=@id";
            ekle = new SqlCommand(sql, baglanti);
            ekle.Parameters.AddWithValue("@id", remId);
            string a = "UPDATE rapor SET Cikis_Agirlik=@Cikis_Agirlik WHERE id=@id2";
            komut3 = new SqlCommand(a, baglanti);
            Random random = new Random();
            int cikisagirlik = random.Next(1, 50) * 200;
            komut3.Parameters.AddWithValue("@Cikis_Agirlik", cikisagirlik);
            komut3.Parameters.AddWithValue("@id2", remId);
            FmGiris fm = new FmGiris();
            string sql1 = "UPDATE rapor SET Cikis_Tarih=GETDATE() WHERE id=@id1";
            komut6 = new SqlCommand(sql1, baglanti);
            komut6.Parameters.AddWithValue("@id1", remId);

            string sorgu = "Select Giris_Agirlik from rapor where id=@id1";
            SqlCommand komut5 = new SqlCommand(sorgu, baglanti);
            komut5.Parameters.AddWithValue("@id1", remId);
            komut5.ExecuteNonQuery();
            
            string sql3 = "UPDATE rapor SET Urun_Agirlik=@urunagirlik WHERE id=@id1";
            yukfarki = new SqlCommand(sql3, baglanti);
            girisagirlik = (int)komut5.ExecuteScalar();
            YukFark = (girisagirlik - cikisagirlik) * -1;
            yukfarki.Parameters.AddWithValue("@id1", remId);
            yukfarki.Parameters.AddWithValue("@urunagirlik", YukFark);
            yukfarki.ExecuteNonQuery();








            ekle.ExecuteNonQuery();
            komut3.ExecuteNonQuery();

            komut6.ExecuteNonQuery();

            baglanti.Close();
            
        }
        private void KayıtSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                string Plaka = Convert.ToString(drow.Cells[0].Value);
                KayıtSil(Plaka);
            }
         
            griddoldur();





        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            guncelle();
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void raporr_Click(object sender, EventArgs e)
        {
            FmRapor frm = new FmRapor();
            frm.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

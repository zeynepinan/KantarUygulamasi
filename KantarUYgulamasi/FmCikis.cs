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
    public partial class FmCikis : Form
    {
        public FmCikis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VUJJUC7E\\SQLEXPRESS;Initial Catalog=kantar;Integrated Security=True");







        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void giris_Click(object sender, EventArgs e)
        {
            
        }

        private void FmCikis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kantarDataSet8.kamyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kamyonTableAdapter3.Fill(this.kantarDataSet8.kamyon);
            // TODO: Bu kod satırı 'kantarDataSet4.kamyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kamyonTableAdapter2.Fill(this.kantarDataSet4.kamyon);
            // TODO: Bu kod satırı 'kantarDataSet2.kamyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            // TODO: Bu kod satırı 'kantarDataSet.kamyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        void KayıtSil(string Plaka)
        {
            string sql = "DELETE FROM kamyon WHERE Plaka=@Plaka";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@Plaka", Plaka);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void Btnkayit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                string Plaka = Convert.ToString(drow.Cells[0].Value);
                KayıtSil(Plaka);
            }
        }

        private void guncelbnt_Click(object sender, EventArgs e)
        {


        }

        private void rapor_Click(object sender, EventArgs e)
        {
            FmRapor frm = new FmRapor();
            frm.Show();
        }
    }
}
    
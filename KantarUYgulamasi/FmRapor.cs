using System;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace KantarUYgulamasi
{
    public partial class FmRapor : Form
    {
        string kelime;
        public FmRapor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VUJJUC7E\\SQLEXPRESS;Initial Catalog=kantar;Integrated Security=True");
        private void FmRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kantarDataSet7.rapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.raporTableAdapter2.Fill(this.kantarDataSet7.rapor);
            // TODO: Bu kod satırı 'kantarDataSet6.rapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.raporTableAdapter1.Fill(this.kantarDataSet6.rapor);
            // TODO: Bu kod satırı 'kantarDataSet3.rapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        

        }

        private void goster_Click(object sender, EventArgs e)
        {
            string donustur = dateTimePicker1.Value.ToString("MM/dd/yyyy");
          //  string donustur = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);
            string donustur2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "select* from rapor where Giris_Tarih between @Tarih1 and @Tarih2";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Tarih1", donustur);
            cmd.Parameters.AddWithValue("@Tarih2", donustur2);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            kelime = "Select * from  rapor where Plaka like '%" + aramatxt.Text +"%'";
            SqlDataAdapter adpr = new SqlDataAdapter(kelime,baglanti);
            adpr.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            excele_aktar(dataGridView1);
        }
        void excele_aktar(DataGridView dg)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }
    }
}

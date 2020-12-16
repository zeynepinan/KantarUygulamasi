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
using Microsoft.VisualBasic;

namespace KantarUYgulamasi
{
    public partial class FmYeni : Form
    {
        public object Interaction { get; private set; }

        public FmYeni()
        {
            InitializeComponent();
        }
        int sifre;
        private void temizle()
        {
            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                {
                    TextBox textbox = (TextBox)nesne;
                    textbox.Clear();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


           
         

            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VUJJUC7E\\SQLEXPRESS;Initial Catalog=kantar;Integrated Security=True");
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from kullanici where kullaniciAdi = '"+textBox1.Text+"'",baglanti);
SqlDataReader dr = sorgula.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Aynı isimli kullanıcı var..");
                temizle();
            }
            else if (textBox2.Text == textBox3.Text)
            { 
                dr.Close();
                SqlCommand cmd = new SqlCommand("insert into kullanici(kullaniciAdi, sifre) values('" +textBox1.Text + "', '" + textBox2.Text + "')", baglanti);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Yeni kullanıcı Eklendi…");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil…");
            }
              
          
            
        }
    }
}

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
    public partial class FmKullanici : Form
    {
        public FmKullanici()
        {
            InitializeComponent();
        }

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici;

            string sifre;

            Kullanici = textBox1.Text;

            sifre = textBox2.Text;

           

            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VUJJUC7E\\SQLEXPRESS;Initial Catalog=kantar;Integrated Security=True");
            baglanti.Open();

            SqlCommand sorgula = new SqlCommand("select * from kullanici where kullaniciAdi = '" + textBox1.Text + "' and sifre='"+textBox2.Text +"'", baglanti);
            SqlDataReader dr = sorgula.ExecuteReader();

            if (dr.Read())
            {
                FmHome frm = new FmHome();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış…");
                temizle();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FmYeni frm =new  FmYeni();
            frm.Show();
            
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


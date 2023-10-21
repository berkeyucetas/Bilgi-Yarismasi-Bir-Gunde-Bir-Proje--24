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

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-LQE0JO3;Initial Catalog=beko;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int zaman = 21;
        private void btnIleri_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;
            btnIleri.Text = "Sonraki Soru";
            sayac++;
            lblSoru.Text = sayac.ToString();
            if(sayac == 1)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru1 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru2 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru3 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru4 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru5 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru6 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 7)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru7 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 8)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru8 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 9)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru9 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
            if (sayac == 10)
            {
                btnIleri.Text = "Bitir";
                btnIleri.Enabled = false;
                baglan.Open();
                SqlCommand cmd = new SqlCommand("Select* from soru10 order by NEWID()", baglan);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    txtSoru.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.BackColor = Color.DarkGray;
                btnB.BackColor = Color.DarkGray;
                btnC.BackColor = Color.DarkGray;
                btnD.BackColor = Color.DarkGray;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == lblDogru.Text)
            {
                puan = puan + 4;
                lblPuan.Text= puan.ToString();
                btnA.Enabled= false;
                btnB.Enabled= false;
                btnC.Enabled= false;
                btnD.Enabled= false;
                btnA.BackColor = Color.Green;
                btnB.BackColor=Color.Red;
                btnC.BackColor=Color.Red;
                btnD.BackColor=Color.Red;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == lblDogru.Text)
            {
                puan = puan + 4;
                lblPuan.Text = puan.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.BackColor = Color.Green;
                btnA.BackColor = Color.Red;
                btnC.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == lblDogru.Text)
            {
                puan = puan + 4;
                lblPuan.Text = puan.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnC.BackColor = Color.Green;
                btnB.BackColor = Color.Red;
                btnA.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == lblDogru.Text)
            {
                puan = puan + 4;
                lblPuan.Text = puan.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnD.BackColor = Color.Green;
                btnB.BackColor = Color.Red;
                btnC.BackColor = Color.Red;
                btnA.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblZaman.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Süre Bitti");
            }
        }
    }
}

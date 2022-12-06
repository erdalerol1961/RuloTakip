using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace RuloStokKarti
{
    public partial class Uretim : Form
    {
        SqlConnection Baglan = new SqlConnection(@"Data Source=SQLSERVER;Initial Catalog=RULOSAC;User ID=Sa;Password=Sa2010");    
        public Uretim()
        {
            InitializeComponent();
        }

        private void Uretim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rULOSACDataSet2.RuloArama' table. You can move, or remove it, as needed.
            this.ruloAramaTableAdapter.Fill(this.rULOSACDataSet2.RuloArama);
            //   BURASI COMBOBOX İÇİNE SQL DEN VERİ OKUR....   ------------------------------------------------------

            // using System.Data.SqlClient;   yerine konacak...
            // SqlConnection Baglan = new SqlConnection(@"Data Source=SQLSERVER;Initial Catalog=RULOSAC;User ID=Sa;Password=Sa2010");    

            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  DISTINCT IslemAnagrup  from dbo.UretimIslemler";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAnaGrup1ComboBox.Items.Clear();

            while (oku.Read())
            {
                // malzemeDovizCinsiComboBox.Items.Add(oku.GetString(0) + " " + oku.GetString(1));
                islemAnaGrup1ComboBox.Items.Add(oku.GetString(0));

            }
            //İşlemimiz bittikten sonra ise her zaman baglantımızı kapatıyoruz...
            Baglan.Close();


            // DAHA SONRA COMBOBOX PROPERY KEY PESSS EVENTINE  BASKA VARI GIRILMESIN DIYORSAN

            //    e.Handled = true;     KOYACAKSIN...



            //  BURAYA KADAR         ----------------------------------------------------------------------------------
        }

        private void islemAnaGrup1ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void islemAltGrup1ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void islemAnaGrup1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup1ComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup1ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup1ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            islemAltGrup1ComboBox.Text = "";
            islemAnaGrup1ComboBox.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RoluAgirlik(this.rULOSACDataSet2.RuloArama, roluAgirlikTextBox.Text.Replace(",", ".").ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloKodu(this.rULOSACDataSet2.RuloArama, ruloKoduTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloAdi(this.rULOSACDataSet2.RuloArama, ruloAdiTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.AnaGrup(this.rULOSACDataSet2.RuloArama, anaGrupComboBox.Text );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloSeriNo(this.rULOSACDataSet2.RuloArama, ruloSeriNoTextBox.Text );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloBarkod(this.rULOSACDataSet2.RuloArama,ruloBarkodTextBox.Text );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.Sinifi(this.rULOSACDataSet2.RuloArama, sınıfıComboBox.Text );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloKalite(this.rULOSACDataSet2.RuloArama, ruloKaliteComboBox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloYuzey(this.rULOSACDataSet2.RuloArama, ruloYuzeyComboBox.Text );
        }

        private void button10_Click(object sender, EventArgs e)
        {


            /*
                         ----   SORGULAMASI ŞU ŞEKİLDE OLACAKTIR SAYISAL ALANLARIN ------------
              
               SELECT RuloId, RuloKodu, RuloAdi, AnaGrup, RuloSeriNo, RuloBarkod, RoluAgirlik, RuloKalinlik, RuloKalite, RuloYuzey, RuloEn, RuloAciklama, Sınıfı, SiparisNo, SiparisTarihi, SiparisVeren, SevkYeri, En, Boy, Adet, Kg, TeslimatTarihi, TalimatVeren, Aciklama, IslemAnaGrup1, IslemAltGrup1, IslemAnaGrup2, IslemAltGrup2, IslemAnaGrup3, IslemAltGrup3, IslemAnaGrup4, IslemAltGrup4, IslemAnaGrup5, IslemAltGrup5, IslemAnaGrup6, IslemAltGrup6 FROM dbo.RuloArama
                WHERE (   CONVERT(varchar(22),RuloKalinlik)  LIKE '%' + @ARuloKalinlik + '%')
              
               PROGRAM İÇİNDE İSE
              
               this.ruloAramaTableAdapter.RuloKalinlik(this.rULOSACDataSet2.RuloArama, ruloKalinlikTextBox.Text.Replace(",", ".").ToString());
              
             */
            this.ruloAramaTableAdapter.RuloKalinlik(this.rULOSACDataSet2.RuloArama, ruloKalinlikTextBox.Text.Replace(",", ".").ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.ruloAramaTableAdapter.RuloEn(this.rULOSACDataSet2.RuloArama, ruloEnTextBox.Text.Replace(",", ".").ToString());
        }
        

    }
}

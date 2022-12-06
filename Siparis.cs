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
    public partial class Siparis : Form
    {
        SqlConnection Baglan = new SqlConnection(@"Data Source=SQLSERVER;Initial Catalog=RULOSAC;User ID=Sa;Password=Sa2010");    
        public Siparis()
        {
            InitializeComponent();
        }
         
        private void talimatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.talimatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rULOSACDataSet);

        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            textBox4.Text = StokKart.StokRuloKalinlik;
            textBox2.Text = StokKart.StokRuloID;
            textBox1.Text =StokKart. StokRuloAdi ;
            ruloIdTextBox.Text = StokKart.StokRuloID ;
           

            
            
            // TODO: This line of code loads data into the 'rULOSACDataSet.Talimat' table. You can move, or remove it, as needed.
            this.talimatTableAdapter.Fill(this.rULOSACDataSet.Talimat, Convert.ToInt32( StokKart.StokRuloID));

            //   BURASI COMBOBOX İÇİNE SQL DEN VERİ OKUR....   ------------------------------------------------------

            // using System.Data.SqlClient;   yerine konacak...
            // SqlConnection Baglan = new SqlConnection(@"Data Source=SQLSERVER;Initial Catalog=RULOSAC;User ID=Sa;Password=Sa2010");    

            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  DISTINCT IslemAnagrup  from dbo.UretimIslemler";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAnaGrup1ComboBox.Items.Clear();
            islemAnaGrup2ComboBox.Items.Clear();
            islemAnaGrup3ComboBox.Items.Clear();
            islemAnaGrup4ComboBox.Items.Clear();
            islemAnaGrup5ComboBox.Items.Clear();
            islemAnaGrup6ComboBox.Items.Clear();
            
            while (oku.Read())
            {
                // malzemeDovizCinsiComboBox.Items.Add(oku.GetString(0) + " " + oku.GetString(1));
                islemAnaGrup1ComboBox.Items.Add(oku.GetString(0));
                islemAnaGrup2ComboBox.Items.Add(oku.GetString(0));
                islemAnaGrup3ComboBox.Items.Add(oku.GetString(0));
                islemAnaGrup4ComboBox.Items.Add(oku.GetString(0));
                islemAnaGrup5ComboBox.Items.Add(oku.GetString(0));
                islemAnaGrup6ComboBox.Items.Add(oku.GetString(0));

            }
            //İşlemimiz bittikten sonra ise her zaman baglantımızı kapatıyoruz...
            Baglan.Close();


            // DAHA SONRA COMBOBOX PROPERY KEY PESSS EVENTINE  BASKA VARI GIRILMESIN DIYORSAN

            //    e.Handled = true;     KOYACAKSIN...



            //  BURAYA KADAR         ----------------------------------------------------------------------------------


         
        }

        private void islemAnaGrup1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup1ComboBox.Text +"'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup1ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup1ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void islemAnaGrup2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup2ComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup2ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup2ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void islemAnaGrup3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup3ComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup3ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup3ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void islemAnaGrup4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup4ComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup4ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup4ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void islemAnaGrup5ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup5ComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup5ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup5ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void islemAnaGrup6ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Closed) Baglan.Open();
            string sorgu = "select  IslemAltGrup  from dbo.UretimIslemler where IslemAnaGrup = '" + islemAnaGrup6ComboBox.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, Baglan);
            SqlDataReader oku = komut.ExecuteReader();
            islemAltGrup6ComboBox.Items.Clear();
            while (oku.Read())
            {
                islemAltGrup6ComboBox.Items.Add(oku.GetString(0));
            }
            Baglan.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            textBox2.Text = StokKart.StokRuloID;
            textBox1.Text = StokKart.StokRuloAdi;
            ruloIdTextBox.Text = StokKart.StokRuloID;
            MessageBox.Show(textBox1.Text + ruloIdTextBox.Text + " Yeni Sipariş Girişi Yapılıyor ");
        }

        private void islemAnaGrup1ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;


        }

        private void islemAnaGrup2ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAnaGrup3ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAnaGrup4ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAnaGrup5ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAnaGrup6ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAltGrup1ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAltGrup2ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAltGrup3ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAltGrup4ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAltGrup5ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

        private void islemAltGrup6ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  klavyeden giriş yapılamasın
            e.Handled = true;
        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            islemAnaGrup1ComboBox.Text = "";
            islemAltGrup1ComboBox.Items.Clear();
            islemAltGrup1ComboBox.Text = "";

        }

        private void label7_Click(object sender, EventArgs e)
        {
            islemAnaGrup2ComboBox.Text = "";
            islemAltGrup2ComboBox.Items.Clear();
            islemAltGrup2ComboBox.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            islemAnaGrup3ComboBox.Text = "";
            islemAltGrup3ComboBox.Items.Clear();
            islemAltGrup3ComboBox.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            islemAnaGrup4ComboBox.Text = "";
            islemAltGrup4ComboBox.Items.Clear();
            islemAltGrup4ComboBox.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            islemAnaGrup5ComboBox.Text = "";
            islemAltGrup5ComboBox.Items.Clear();
            islemAltGrup5ComboBox.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            islemAnaGrup6ComboBox.Text = "";
            islemAltGrup6ComboBox.Items.Clear();
            islemAltGrup6ComboBox.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

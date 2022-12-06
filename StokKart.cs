using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuloStokKarti
{

    public partial class StokKart : Form
    {
 
        public StokKart()
        {
            InitializeComponent();
        }
        public static string StokRuloAdi = "";
        public static  string StokRuloID = "";
        public static string StokRuloKalinlik;
        private void ruloStokKartiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ruloStokKartiBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.ruloStokKartDataSet);
            }
            catch
            {
                MessageBox.Show(e.ToString()+ " Lutfen girisi kontrol ediniz ");
            }


        }

        private void StokKart_Load(object sender, EventArgs e)
        {
        
            // TODO: This line of code loads data into the 'ruloStokKartDataSet.RuloStokKarti' table. You can move, or remove it, as needed.
            this.ruloStokKartiTableAdapter.Fill(this.ruloStokKartDataSet.RuloStokKarti);

        }

      //  private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
   //     {
          //  try
          //  {
             //   this.Validate();
             //   this.ruloStokKartiBindingSource.EndEdit();
              //  this.tableAdapterManager.UpdateAll(this.ruloStokKartDataSet);
         //   }
          //  catch
          //  {
           //     MessageBox.Show(e.ToString() + " Lutfen girisi kontrol ediniz ");
          //  }
     //   }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloKodu(this.ruloStokKartDataSet.RuloStokKarti,ruloKoduTextBox.Text );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloAdi(this.ruloStokKartDataSet.RuloStokKarti,ruloAdiTextBox.Text );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.AnaGrup(this.ruloStokKartDataSet.RuloStokKarti,anaGrupComboBox.Text );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloSeriNo(this.ruloStokKartDataSet.RuloStokKarti, ruloSeriNoTextBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloBarkod(this.ruloStokKartDataSet.RuloStokKarti,ruloBarkodTextBox.Text );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloKalite(this.ruloStokKartDataSet.RuloStokKarti,ruloKaliteComboBox.Text );
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloYuzey(this.ruloStokKartDataSet.RuloStokKarti, ruloYuzeyComboBox.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloAciklama(this.ruloStokKartDataSet.RuloStokKarti, ruloAciklamaRichTextBox.Text );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.UreticiFirma(this.ruloStokKartDataSet.RuloStokKarti,ureticiFirmaComboBox.Text) ;
        }

        private void button10_Click(object sender, EventArgs e)
        {
             this.ruloStokKartiTableAdapter.GeldigiFirma(this.ruloStokKartDataSet.RuloStokKarti,geldigiFirmaComboBox.Text ) ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloIrsaliyeNo (this.ruloStokKartDataSet.RuloStokKarti, ruloIrsaliyeNoTextBox.Text );
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.RuloFaturaNo (this.ruloStokKartDataSet.RuloStokKarti,ruloFaturaNoTextBox.Text );
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.Deposu (this.ruloStokKartDataSet.RuloStokKarti,deposuComboBox.Text );
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            try
            {
           this.Validate();
            this.ruloStokKartiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruloStokKartDataSet);
           }
           catch
            {
              MessageBox.Show(e.ToString() + " Lutfen girisi kontrol ediniz ");
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ruloStokKartiTableAdapter.Fill(this.ruloStokKartDataSet.RuloStokKarti);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ruloStokKartiTableAdapter.Sinifi(this.ruloStokKartDataSet.RuloStokKarti, sınıfıComboBox.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(ruloAdiTextBox.Text))
            {
                MessageBox.Show("Lüfen Rulo Seçimi Yapınız Yada Yeni Rulo Giriniz ");
            }
            else
            {
                StokRuloKalinlik = ruloKalinlikTextBox.Text;
                StokRuloAdi = ruloAdiTextBox.Text;
                StokRuloID = ruloIdTextBox.Text;
                
                Siparis newform = new Siparis();
                newform.ShowDialog();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ruloAdiTextBox.Text))
            {
                MessageBox.Show("Lüfen Rulo Seçimi Yapınız Yada Yeni Rulo Giriniz ");
            }
            else
            {
                StokRuloKalinlik = ruloKalinlikTextBox.Text;
            StokRuloAdi = ruloAdiTextBox.Text;
            StokRuloID = ruloIdTextBox.Text;
            Uretim newform = new Uretim();
            newform.ShowDialog();
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
              if (String.IsNullOrEmpty(ruloAdiTextBox.Text))
            {
                MessageBox.Show("Lüfen Rulo Seçimi Yapınız Yada Yeni Rulo Giriniz ");
            }
            else
            {
                StokRuloKalinlik = ruloKalinlikTextBox.Text;
            StokRuloAdi = ruloAdiTextBox.Text;
            StokRuloID = ruloIdTextBox.Text;
            Sevkiyat newform = new Sevkiyat();
            newform.ShowDialog();
            }
        }

        private void ruloAdiLabel_Click(object sender, EventArgs e)
        {
            ruloAdiTextBox.Text =anaGrupComboBox.Text+" "+ ruloKalinlikTextBox.Text + " X " + ruloEnTextBox.Text + " " +   roluAgirlikTextBox.Text +" KG "+ruloKaliteComboBox.Text+" Klt "+ruloYuzeyComboBox.Text +" Yzy";
        }

        private void ruloKoduLabel_Click(object sender, EventArgs e)
        {
            ruloKoduTextBox.Text = anaGrupComboBox.Text + " " + roluAgirlikTextBox.Text + " KG ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Islemler  newform = new Islemler ();
            newform.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            /*   sql de . ve , den dolayı sayısal alanı aramak için aşağıdaki işleme bakınız....
             örnek query 
             * 
             * SELECT        AnaGrup, Deposu, GeldigiFirma, RoluAgirlik, RuloAciklama, RuloAcilisTarihi, RuloAdi, RuloBarkod, RuloBoy, RuloEn, RuloFaturaNo, RuloFaturaTarih, RuloFiyati, 
                          RuloId, RuloIrsaliyeNo, RuloIrsaliyeTarih, RuloKalinlik, RuloKalite, RuloKodu, RuloSeriNo, RuloYuzey, Sınıfı, UreticiFirma
                            FROM            RuloStokKarti
               WHERE        (CONVERT(varchar(22), RoluAgirlik) LIKE '%' + @ARoluAgirlik + '%')
             * 
             * 
             * convert ile sayısal alanı varchar a ceviriyoruz daha sonra . ıle , yer degisiyor ve sonuca gidiyoruz.
             * 
             * 
             * 
             * 

             */

            this.ruloStokKartiTableAdapter.RuloAgirlik(this.ruloStokKartDataSet.RuloStokKarti, roluAgirlikTextBox.Text.Replace(",",".").ToString());
        }

        private void roluAgirlikLabel_Click(object sender, EventArgs e)
        {

        }

        private void roluAgirlikTextBox_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}

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
    public partial class Uretim1 : Form
    {
        public Uretim1()
        {
            InitializeComponent();
        }

        private void Uretim_Load(object sender, EventArgs e)
        {
            textBox3.Text = StokKart.StokRuloKalinlik;
            textBox2.Text = StokKart.StokRuloID;
            textBox1.Text = StokKart.StokRuloAdi;
        }
    }
}

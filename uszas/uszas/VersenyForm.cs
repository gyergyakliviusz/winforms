using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszas
{
    public partial class VersenyForm : Form
    {
        public List<Versenyzo> Versenyzok { get; private set; }
        public string UszasNem { get; private set; }
        public int Tav { get; private set; }
        private DateTime alap = new DateTime(2000, 01, 01, 0, 0, 0);
        private int sorSzam;

        public VersenyForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = alap;
            comboUszasNem.SelectedIndex = 0;
        }

        internal void Fogad(List<Versenyzo> versenyzok)
        {
            Versenyzok = versenyzok;
        }

        private void VersenyzoBeallitas()
        {
            dateTimePicker1.Value = alap;
            if(sorSzam < Versenyzok.Count)
            {
                txtVersenyzo.Text = Versenyzok[sorSzam].ToString();
            }
            else
            {
                this.Close();
            }
        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            TimeSpan idoEredmeny = dateTimePicker1.Value - alap;
            Versenyzok[sorSzam].Versenyez(idoEredmeny);
            sorSzam++;
            VersenyzoBeallitas();
        }
    }
}

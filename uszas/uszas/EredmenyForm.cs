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
    public partial class EredmenyForm : Form
    {
        private List<Versenyzo> versenyzok;

        public EredmenyForm()
        {
            InitializeComponent();
        }

        public void EredmenyHirdetes(string uszasNem, int tav, List<Versenyzo> versenyzok)
        {
            lblCim.Text = tav + " méteres" + uszasNem + " eredménye: ";
            this.versenyzok = versenyzok;
            foreach(Versenyzo versenyzo in versenyzok)
            {
                lstVersenyzok.Items.Add(versenyzo);
            }
        }

        private void lstVersenyzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Versenyzo versenyzo = (Versenyzo)lstVersenyzok.SelectedItem;
                txtRajtszam.Text = versenyzo.Rajtszam;
                txtOrszag.Text = versenyzo.Orszag;
                txtIdoeredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss");
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás választás", "Hiba");
            }
        }

        private void rdBtnNevsor_CheckedChanged(object sender, EventArgs e)
        {
            lstVersenyzok.Sorted = true;
        }

        private void rdBtnEredmeny_CheckedChanged(object sender, EventArgs e)
        {
            lstVersenyzok.Sorted = false;
            lstVersenyzok.Items.Clear();
            Versenyzo temp;
            for(int i = 0; i < versenyzok.Count-1; i++)
            {
                for(int j = i + 1; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].IdoEredmeny > versenyzok[j].IdoEredmeny)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }
            foreach(Versenyzo versenyzo in versenyzok)
            {
                lstVersenyzok.Items.Add(versenyzo);
            }
        }
    }
}

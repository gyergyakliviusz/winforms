using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszas
{
    public partial class InditoForm : Form
    {
        List<Versenyzo> versenyzok = new List<Versenyzo>();

        public InditoForm()
        {
            InitializeComponent();
        }

        private void AdatBeolvasas()
        {
            StreamReader olvasoCsatorna = new StreamReader("uszok.txt");

            string adat = olvasoCsatorna.ReadLine();
            while (adat != null)
            {
                Feldolgoz(adat);
                adat = olvasoCsatorna.ReadLine();
            }
            olvasoCsatorna.Close();
        }

        private void Feldolgoz(string adat)
        {
            string nev, orszag, zaszlo;
            string[] tordelt = adat.Split(';');

            nev = tordelt[0];
            orszag = tordelt[0];
            zaszlo = tordelt[0];
            versenyzok.Add(new Versenyzo(nev, orszag, zaszlo));
        }

        private void versenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersenyForm.Fogad(versenyzok);

            this.Hide();
            VersenyForm.ShowDialog();
            this.Show();

            eredmenyToolStripMenuItem.Enabled = true;
            versenyToolStripMenuItem.Enabled = false;
            mentesToolStripMenuItem.Enabled = true;
            int tav = VersenyForm.Tav;
            string uszasNem = VersenyForm.UszasNem;
            EredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
        }

        private void eredmenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EredmenyForm.ShowDialog();
            this.Show();
        }

        private void nevjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keszito = "BitBajnok";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }

        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter iroCsatorna = new StreamWriter("eredmeny.txt");
            foreach(var versenyzo in versenyzok)
            {
                iroCsatorna.WriteLine(versenyzo.Rajtszam + ";" + versenyzo.Nev + ";" + versenyzo.Orszag + ";" + versenyzo.IdoEredmeny);
            }
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

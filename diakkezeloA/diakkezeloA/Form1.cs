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

namespace diakkezeloA
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        List<Diak> diakok = new List<Diak>();
        List<CheckBox> chkBoxok = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "diakok.txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = aktiv;
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }

        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    Feldolgoz(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor: " + ex.Message, "Hiba");
                }
            }
        }

        private void Feldolgoz(string fajlNev)
        {
            var lines = File.ReadAllLines(fajlNev);
            foreach (var line in lines)
            {
                string[] adatok = line.Split(';');
                if (adatok.Length == 3)
                {
                    Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
                    diakok.Add(diak);
                }
            }
        }

        private int kezdoX = 40;
        private int kezdoY = 40;
        private int chkYkoz = 40;

        private void FelrakDiakok()
        {
            CheckBox chkBox;

            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chkYkoz);
                chkBox.Text = diakok[i].ToString();

                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott)
            {
                MessageBox.Show("Senkit sem választott", "Hiba");
            }
            else
            {
                MinKeres();
            }
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            if (lstKivalasztottak.Items.Count == 0) return;

            int min = (lstKivalasztottak.Items[0] as Diak).SzulEv;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.SzulEv < min) min = diak.SzulEv;
            }
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.SzulEv == min) lstLegidosebbek.Items.Add(diak);
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.SzulEv;
        }
    }

    public class Diak
    {
        public string Nev { get; private set; }
        public string TanulmanyiKod { get; set; }
        public int SzulEv { get; set; }

        public Diak(string nev, string tanulmanyiKod, int szulEv)
        {
            Nev = nev;
            TanulmanyiKod = tanulmanyiKod;
            SzulEv = szulEv;
        }

        public override string ToString()
        {
            return this.Nev;
        }
    }
}

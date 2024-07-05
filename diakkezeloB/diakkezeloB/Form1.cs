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

namespace diakkezeloB
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        List<Diak> diakok = new List<Diak>();
        List<int> evek = new List<int>();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "diakok.txt";
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor: " + ex.Message, "Hiba");
                }
            }
        }

        private void Feldolgoz(string fajlNev)
        {
            string[] adatok = adat.Split(';');
            Diak diak;
            diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            lstDiakok.Items.Add(diak);
            if (!evek.Contains(diak.SzulEv)) evek.Add(diak.SzulEv);
        }

        private int kezdoX = 40;
        private int kezdoY = 40;
        private int btnXkoz = 40;

        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXkoz, kezdoY);
                btn.Text = evek[i].ToString();
                btn.Click += new System.EventHandler(Kivalaszt);
                pnlEvek.Controls.Add(btn);
                btnEvek.Add(btn);
            }
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

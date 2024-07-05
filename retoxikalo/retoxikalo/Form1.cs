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

namespace retoxikalo
{

    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 10;

        private ItalLapForm italForm = new ItalLapForm();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
        }

        private void GaleriaMenuItem_Click(object sender, EventArgs e)
        {
            GaleriaForm galeriaForm = new GaleriaForm();
            galeriaForm.Atad(kepek);
            galeriaForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {
                MessageBox.Show("HIba a képek létrehozásakor", "Hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 1; i <= kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i + ".jpg");
                kepek.Add(kep);
            }
        }

        private void openMenuItem_Click(Object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader olvasoCsatorna = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);

                    AdatBevitel(olvasoCsatorna);

                    ItallapMenuItem.Enabled = true;
                    SaveMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (olvasoCsatorna != null)
                    {
                        olvasoCsatorna.Close();
                    }
                }
            }
        }

        private void AdatBevitel(StreamReader olvasoCsatorna)
        {
            string sor = olvasoCsatorna.ReadLine();
            string[] adatok;
            while(sor != null)
            {
                adatok = sor.Split(';');
                italok.Add(new Ital(adatok[0]), int.Parse(adatok[1]));
                sor = olvasoCsatorna.ReadLine();
            }
        }
    }

    public partial class ItalLapForm : Form
    {
        public ItalLapForm()
        {
            InitializeComponent();
        }

        private List<Ital> italok = new List<Ital>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();
        private List<TextBox> txtBoxok = new List<TextBox>();

        private int bal = 10, fent = 10, chkXMeret = 250, chkYTav = 40, txtXMeret = 30, txtYMeret = 17, xKoz = 5;

        private int maxAdag = 999;

        internal void ArlapotIr(List<Ital> italok)
        {
            pnlValasztek.Controls.Clear();
            chkBoxok.Clear();
            txtBoxok.Clear();

            this.italok = italok;

            CheckBox chkBox;
            TextBox txtBox;
            Label lbl;

            for (int i = 0; i < italok.Count; i++)
            {
                chkBox = new CheckBox();
                txtBox = new TextBox();
                lbl = new Label();

                chkBox.Location = new Point(bal, fent + i * chkYTav);
                chkBox.Size = new Size(chkXMeret, txtYMeret);
                chkBox.Text = italok[i].Arlistaba();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;

                txtBox.Location = new Point(bal + chkXMeret, fent + i * chkYTav - 2);
                txtBox.Size = new Size(txtXMeret, txtYMeret);

                lbl.AutoSize = true;
                lbl.Location = new Point(bal + chkXMeret + txtXMeret + xKoz, fent + i * chkYTav + 1);
                lbl.Text = "adag";

                pnlValasztek.Controls.Add(chkBox);
                pnlValasztek.Controls.Add(txtBox);
                pnlValasztek.Controls.Add(lbl);

                chkBoxok.Add(chkBox);
                txtBoxok.Add(txtBox);
            }
        }
    }

    class Ital
    {
        public string ItalNev { get; set; }
        public int EgysegAr { get; set; }
        public int Mennyiseg { get; private set; }
        public int OsszMennyiseg { get; private set; }
        public string Bevetel { get; private set; }

        public Ital(string italNev, int egysegAr)
        {
            this.ItalNev = italNev;
            this.EgysegAr = egysegAr;
        }

        public void Rendel(int db)
        {
            Mennyiseg += db;
        }

        public int Fizetendo()
        {
            return Mennyiseg * EgysegAr;
        }

        public void Fizet()
        {
            OsszMennyiseg += Mennyiseg;
            Bevetel += Mennyiseg * EgysegAr;
            Mennyiseg = 0;
        }

        public string Arlistaba()
        {
            return ItalNev + " (" + EgysegAr + " Ft)";
        }

        public string Konyvelesbe()
        {
            return ItalNev + ";" + OsszMennyiseg + ";" + Bevetel;
        }

        public override string ToString()
        {
            return Mennyiseg.ToString().PadLeft(4) + " " + ItalNev.PadRight(35) + Fizetendo().ToString().PadLeft(10) + " Ft";
        }
    }

    public partial class SzamlaForm : Form
    {
        public SzamlaForm()
        {
            InitializeComponent();
        }

        internal void Kitolt(List<Ital> italok)
        {
            rchTxtSzamla.Clear();
            foreach (Ital item in italok)
            {
                if (item.Mennyiseg != 0)
                {
                    rchTxtSzamla.Text += item.ToString() + "\r\n";
                }
            }
        }

        private void SaveMenuItem_Click(object sender EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter iroCsatorna = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    iroCsatorna = new StreamWriter(fajlNev);
                    FajlbaIr(iroCsatorna);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "Hiba");
                }
                finally
                {
                    if (iroCsatorna != null)
                    {
                        iroCsatorna.Close();
                    }
                }
            }
        }

        private void FajlbaIr(StreamWriter iroCsatorna)
        {
            foreach (Ital item in italok)
            {
                iroCsatorna.WriteLine(item.Konyvelesbe());
            }
        }
    }

    public partial class GaleriaForm : Form
    {
        public GaleriaForm()
        {
            InitializeComponent();
        }

        private List<Image> kepek = new List<Image>();
        private int aktualisIndex;

        internal void Atad(List<Image> kepek)
        {
            this.kepek = kepek;
            pictureBox1.Image = kepek[aktualisIndex];
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            if (aktualisIndex < kepek.Count - 1) aktualisIndex++;
            else aktualisIndex = 0;
            pictureBox1.Image = kepek[aktualisIndex];
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            if (aktualisIndex > 0) aktualisIndex--;
            else aktualisIndex = kepek.Count - 1;
            pictureBox1.Image = kepek[aktualisIndex];
        }
    }

    public partial class SugoForm : Form
    {
        private RichTextBox rchTxtSugo;

        public SugoForm()
        {
            InitializeComponent();
            rchTxtSugo.AppendText(
                "Ez a program a vendéglátó-ipari egységek kezelése céljából készült.\n" +
                "1. Adatok betöltése: Fájl megnyitása a Fájl menüből.\n" +
                "2. Itallap megtekintése és rendelés: Itallap menüből.\n" +
                "3. Számla és fizetés: Jobb egérgombbal kattintva a rendelési felületen.\n" +
                "4. Képgaléria: Képek megtekintése a Galéria menüből.\n"
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace datum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
        }

        private DateTime ma = DateTime.Now;
        private DateTime szulDatum;
        private DateTime valasztottDatum;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDatum.Text = ma.ToString("F");
            lblGratulacio.Text = "";
            valasztottDatum = dateTimePicker1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.ToString("F");
        }

        private void mskdTxtSzulDatum_Leave(object sender, EventArgs e)
        {
            Gratulacio();
        }

        private void Gratulacio()
        {
            try
            {
                if (!mskdTxtSzulDatum.MaskFull) throw new Exception();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulDatum.Text);
                    if (szulDatum > ma) throw new Exception();
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        lblGratulacio.Text = "Isten éltessen!";
                    }
                    else
                    {
                        lblGratulacio.Text = "Boldog hétköznapot!";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás dátum", "Hiba");
                mskdTxtSzulDatum.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gratulacio();
            }
        }

        private void btnKiir_Click(object sender, EventArgs e)
        {
            int evek = ma.Year - szulDatum.Year;
            txtEvSzam.Text = evek.ToString();
            string nap = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(szulDatum.DayOfWeek);
            txtNap.Text = nap;
            txtNapSorszam.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            valasztottDatum = dateTimePicker1.Value;
            txtNapSorszam.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void txtNapSzam_TextChanged(object sender, EventArgs e)
        {
            int hossz = txtNapSzam.Text.Length;
            if ((hossz >= 2 && txtNapSzam.Text.ElementAt(0) == '-') ||
                (hossz >= 1 && txtNapSzam.Text.ElementAt(0) != '-'))
            {
                try
                {
                    int nap = int.Parse(txtNapSzam.Text);
                    txtKesobbiDatum.Text = valasztottDatum.AddDays(nap).ToString("d");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem számot írt", "Hiba");
                }
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
            }
            lblGratulacio.Text = "";
            mskdTxtSzulDatum.Clear();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
}

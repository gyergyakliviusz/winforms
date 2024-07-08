using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InditoForm());
        }
    }

    public class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public string Orszag { get; private set; }
        public string Zaszlo { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        private static int sorSzam;

        public Versenyzo(string nev, string orszag, string zaszlo)
        {
            this.Nev = nev;
            this.Orszag = orszag;
            this.Zaszlo = zaszlo;
            sorSzam++;
            this.Rajtszam = (sorSzam < 10)?("0" + sorSzam): sorSzam.ToString();
        }

        public void Versenyez(TimeSpan idoEredmeny)
        {
            this.IdoEredmeny = idoEredmeny;
        }
    }
}

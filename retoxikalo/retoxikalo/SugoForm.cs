using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoxikalo
{
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phasmo
{
    public partial class Opisducha : Form
    {
        public Opisducha(string nazwa)
        {
            InitializeComponent();
            var baza = new DaneZbazy();

            List<Dane> dane = baza.szukaj_poNazwie(nazwa);
            Nazwa.Text = dane[0].nazwa;
            Opis.Text = dane[0].opis;
            Slabosc.Text = dane[0].slabosc;
            Moc.Text = dane[0].moce;
            Dowody.Text = dane[0].dowody;
        }

        private void Opisducha_Load(object sender, EventArgs e)
        {

        }
    }
}

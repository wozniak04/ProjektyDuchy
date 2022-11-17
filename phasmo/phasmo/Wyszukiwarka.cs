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
    public partial class formWyszukiwarka : Form
    {
        public formWyszukiwarka()
        {
            InitializeComponent();
        }
        DaneZbazy pol = new DaneZbazy();
        private void formWyszukiwarka_Load(object sender, EventArgs e)
        {
            cmbDowod1.SelectedIndex = 0;
            cmbDowod2.SelectedIndex = 0;
            cmbDowod3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Dane> duchy = new List<Dane>();
            
            List<string> dowody = new List<string>();
            if (cmbDowod1.SelectedIndex != 0)
                dowody.Add(cmbDowod1.Text.ToString());

            if (cmbDowod2.SelectedIndex != 0)
                dowody.Add(cmbDowod2.Text.ToString());

            if (cmbDowod3.SelectedIndex != 0)
                dowody.Add(cmbDowod3.Text.ToString());

            duchy.AddRange(pol.szukaj_poDowodach(dowody));

            List<string> nazwa = new List<string>();
            List<string> dowodyy = new List<string>();
           
            foreach (Dane x in duchy)
            {
                nazwa.Add(x.nazwa);
                dowodyy.Add(x.dowody);
            }

            wiki wi = new wiki(nazwa, dowodyy);
            wi.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }


        private string _dowody;
        public string Dowody { get { return _dowody; } set { _dowody = value; lblDowody.Text = value; } }

        private string _nazwa;

        public string Nazwa { get { return _nazwa; } set { _nazwa = value; lblNazwa.Text = value; } }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void ListItem_Click(object sender, EventArgs e)
        {
            var okno = new Opisducha(this._nazwa);
            okno.ShowDialog();
        }

        private void lblNazwa_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

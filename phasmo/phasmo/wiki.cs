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
    public partial class wiki : Form
    {
        List<string> nazwa = new List<string>();
        List<string> dowody = new List<string>();
        public wiki(List<string> _nazwa, List<string> _dowody)
        {
            nazwa.AddRange(_nazwa);
            dowody.AddRange(_dowody);
            InitializeComponent();
        }

        private void populateItems()
        {
            ListItem[] listItems = new ListItem[nazwa.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Nazwa = nazwa[i];
                listItems[i].Dowody = dowody[i];

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }

        private void wiki_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

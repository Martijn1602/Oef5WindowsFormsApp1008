using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef5WindowsFormsApp1008
{
    public partial class Wedstrijdopstelling : Form
    {
        public Wedstrijdopstelling()
        {
            InitializeComponent();
        }
        List<string> SpelersLijst = new List<string>();
        
        
        private void Wedstrijdopstelling_Load(object sender, EventArgs e)
        {
            SpelersLijst.Add("Eden Maesen");
            SpelersLijst.Add("Ferre Grammens");
            SpelersLijst.Add("Rune Mouton");
            SpelersLijst.Add("Mathieu Gryson");
            SpelersLijst.Add("Louis Van Hulle");
            SpelersLijst.Add("Arthur Versyck");
            SpelersLijst.Add("Lars Tilleman");
            SpelersLijst.Add("Senne Baes");
            SpelersLijst.Add("Cedrik Decorte");
            SpelersLijst.Add("Tibe Dekoker");
            SpelersLijst.Add("Lenn Rabaey");
            SpelersLijst.Add("Ayden Brouckaert");
            SpelersLijst.Add("Runar Sanders");
            SpelersLijst.Add("Massimo Canalis");
            SpelersLijst.Add("Nolan Buyle");
            SpelersLijst.Add("Alois Qvick");
            SpelersLijst.Add("Maurice Heytens");

            foreach (var item in SpelersLijst)
            {
                CbKeeper.Items.Add(item);
                cbVerd.Items.Add(item);
                cbRflank.Items.Add(item);
                cbLflank.Items.Add(item);
                cbSpits.Items.Add(item);
                cbBZ1.Items.Add(item);
                cbBZ2.Items.Add(item);
            }

        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {

        }
    }
}

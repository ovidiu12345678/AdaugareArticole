using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaugareArticole
{
    public partial class AdaugareArticol : Form
    {
        // Campuri publice

        public string numeArticol;
        public decimal pret;
        public double cantitate;
        public AdaugareArticol()
        {
            InitializeComponent();
            
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            numeArticol = textArticol.Text;

            try
            {
                pret = decimal.Parse(textPret.Text, System.Globalization.NumberStyles.Any);
                cantitate = double.Parse(textCantitate.Text);
            }
            catch
            {
                MessageBox.Show("Ati introdus caractere / cuvant, va rugam sa introduceti valorile de tip intreg/real ! ");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

       
    }
}

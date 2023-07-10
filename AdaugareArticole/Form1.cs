using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AdaugareArticole
{
    public partial class Form1 : Form
    {
        // Camp global privat

        private decimal total = 0;
        private ListViewItem listViewItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            AdaugareArticol adaugareArticol = new AdaugareArticol();

            if (adaugareArticol.ShowDialog() == DialogResult.OK)
            {
               
                decimal pret = adaugareArticol.pret;
                decimal cantitate = (decimal)adaugareArticol.cantitate;
                decimal totalArticol = pret * cantitate;

                // adaugarea valorii in lista

                ListViewItem listViewItem = lstArticole.Items.Add(adaugareArticol.numeArticol);
                listViewItem.SubItems.Add(pret.ToString());
                listViewItem.SubItems.Add(cantitate.ToString());
                listViewItem.SubItems.Add(totalArticol.ToString() + $" {"lei"} ");



                // Calculare total articol
                
                total += totalArticol;

                textTotal.Text = total.ToString("C");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnSergereElementeDinLista_Click(object sender, EventArgs e)
        {
            

            if (lstArticole.SelectedItems.Count > 0)
            {
                
                lstArticole.Items.Remove(lstArticole.SelectedItems[0]);  

            }


        }
        
    }
}
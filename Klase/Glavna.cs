using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klase
{
    public partial class Glavna : Form
    {
        
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string opis = txtOpis.Text;
            string vrsta = txtVrsta.Text;
            string unos = txtDatum.Text;
            bool ok = DateTime.TryParse(unos, out DateTime datum);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format");
                return;
            }
            unos = txtCijena.Text;
            ok = double.TryParse(unos, out double cijena);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format");
                return;
            }
            string izdavac = txtIzdavac.Text;
            Igra igra = new Igra();
            try
            {
                igra.Naziv = naziv;
                igra.Opis = opis;
                igra.Vrsta = vrsta;
                igra.DatumIzdavanja = datum;
                igra.Cijena = cijena;
                igra.Izdavac = izdavac;
                MessageBox.Show("Podaci su uspješno uneseni");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška: {ex.Message}");
            }
            
        }
    }
}

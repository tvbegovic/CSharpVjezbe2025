using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadatak2
{
    public partial class Glavna : Form
    {
        List<Polaznik> polaznici = new List<Polaznik>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string oib = txtOib.Text;
            string unos = txtDatumUpisa.Text;
            bool ok = DateTime.TryParse(unos, out DateTime datum);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format datuma");
                return;
            }
            unos = txtDug.Text;
            ok = double.TryParse(unos, out double dug);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format duga");
                return;
            }
            Polaznik polaznik = new Polaznik();
            try
            {
                polaznik.Ime = ime;
                polaznik.Prezime = prezime;
                polaznik.Oib = oib;
                polaznik.DatumUpisa = datum;
                polaznik.Dug = dug;
                polaznici.Add(polaznik);
                AzurirajGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
            }

        }
        void AzurirajGrid()
        {
            dgvPolaznici.DataSource = null;
            dgvPolaznici.DataSource = polaznici;
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            string[] redci = File.ReadAllLines("polaznici.txt");
            foreach (var red in redci)
            {
                string[] stupci = red.Split(';');
                Polaznik polaznik = new Polaznik();
                polaznik.Ime = stupci[0];
                polaznik.Prezime= stupci[1];
                polaznik.Oib= stupci[2];
                bool ok = DateTime.TryParse(stupci[3], out DateTime datum);
                if(ok)
                    polaznik.DatumUpisa = datum;
                ok = double.TryParse(stupci[4], out double dug);
                if (ok)
                    polaznik.Dug = dug;
                polaznici.Add(polaznik);
            }
            AzurirajGrid();
        }
    }
}

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

namespace Zadatak2
{
    public partial class Glavna : Form
    {
        List<Knjiga> knjige = new List<Knjiga>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string autor = txtAutor.Text;
            string isbn = txtISBN.Text;
            string unos = txtDatumUpisa.Text;
            bool ok = DateTime.TryParse(unos, out DateTime datum);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format datuma");
                return;
            }
            unos = txtCijena.Text;
            ok = double.TryParse(unos, out double cijena);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format cijene");
                return;
            }
            Knjiga knjiga = new Knjiga();
            try
            {
                knjiga.Naziv = naziv;
                knjiga.Autor = autor;
                knjiga.Isbn = isbn;
                knjiga.DatumIzdavanja = datum;
                knjiga.Cijena = cijena;
                knjige.Add(knjiga);
                AzurirajGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška: {ex.Message}");
            }

        }

        void AzurirajGrid()
        {
            dgvKnjige.DataSource = null;
            dgvKnjige.DataSource = knjige;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            StreamWriter datoteka = new StreamWriter("knjige.txt");
            foreach (var knjiga in knjige)
            {
                datoteka.WriteLine($"{knjiga.Naziv};{knjiga.Isbn};{knjiga.Cijena};{knjiga.Autor};{knjiga.DatumIzdavanja}");
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            string[] redci = File.ReadAllLines("knjige.txt");
            foreach (string r in redci)
            {
                string[] stupci = r.Split(';');
                Knjiga knjiga = new Knjiga();
                knjiga.Naziv = stupci[0];
                knjiga.Isbn = stupci[1];
                bool ok = double.TryParse(stupci[2], out double cijena);
                if (ok)
                    knjiga.Cijena = cijena;
                knjiga.Autor = stupci[3];
                ok = DateTime.TryParse(stupci[4], out DateTime datum);
                if (ok)
                    knjiga.DatumIzdavanja = datum;
                knjige.Add(knjiga);
            }
            AzurirajGrid();
        }
    }
}

using Projekt.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Repozitorij;

namespace Projekt
{
    public partial class PregledPitanjaForm : Form
    {
        korisnik ulogiraniKorisnik;
        string cjelina;
        ispit odabranKviz;
        public PregledPitanjaForm(korisnik ulogiran, ispit odabranIspit, string nazivCjeline)
        {
            ulogiraniKorisnik = ulogiran;
            odabranKviz = odabranIspit;
            cjelina = nazivCjeline;
            InitializeComponent();
        }

        private void PregledPitanjaForm_Load(object sender, EventArgs e)
        {
            cjelinaLabel.Text = cjelina;
            ispitLabel.Text = odabranKviz.naziv_ispita;
            RefreshDgvPitanjaOdgovori(odabranKviz);
        }

        private void RefreshDgvPitanjaOdgovori(ispit odabranKviz)
        {
            dgvPitanjaOdgovori.DataSource = RepozitorijKviz.DohvatiPitanjaOdgovoreZaPregled(odabranKviz);
            dgvPitanjaOdgovori.Columns["pitanje_id"].Visible = false;
            dgvPitanjaOdgovori.Columns["odg1_id"].Visible = false;
            dgvPitanjaOdgovori.Columns["odg2_id"].Visible = false;
            dgvPitanjaOdgovori.Columns["odg3_id"].Visible = false;
            dgvPitanjaOdgovori.Columns["odg4_id"].Visible = false;
            dgvPitanjaOdgovori.Columns["OdgTocan_id"].Visible = false;
        }

        private void dodajNovoPitanjeButton_Click(object sender, EventArgs e)
        {
            DodajPitanjeForm dodajPitanjeForm = new DodajPitanjeForm(ulogiraniKorisnik);
            dodajPitanjeForm.ShowDialog();
        }

        private void azurirajPitanjeButton_Click(object sender, EventArgs e)
        {
            pitanjeOdgovoriView odabranoPitanje = OdabranRedak();
            DodajPitanjeForm dodajPitanjeForm = new DodajPitanjeForm(ulogiraniKorisnik, odabranoPitanje);
            dodajPitanjeForm.ShowDialog();
        }

        private pitanjeOdgovoriView OdabranRedak()
        {
            return dgvPitanjaOdgovori.CurrentRow.DataBoundItem as pitanjeOdgovoriView;
        }

        private void izbrisiPitanjeButton_Click(object sender, EventArgs e)
        {
            pitanjeOdgovoriView odabranRedak = OdabranRedak();
            int provjera = RepozitorijKviz.IzbrisiPitanjeIOdgovore(odabranRedak);
            RefreshDgvPitanjaOdgovori(odabranKviz);
            if(provjera == 1)
            {
                MessageBox.Show("Pitanje i odgovori uspješno obrisano!", "Uspješno brisanje");
            } else
            {
                MessageBox.Show("Pitanje i odgovori nisu obrisani!", "Poruka o grešci");
            }
        }

        private void PregledPitanjaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this,"Pomoc.chm", HelpNavigator.Topic, "pregledavanjePitanja.htm");
        }
    }
}

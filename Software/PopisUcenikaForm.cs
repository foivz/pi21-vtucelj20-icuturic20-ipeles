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
    public partial class PopisUcenikaForm : Form
    {
        korisnik ulogiraniKorisnik;
        public PopisUcenikaForm(korisnik logirani)
        {
            ulogiraniKorisnik = logirani;
            InitializeComponent();
        }

        private void PopisUcenikaForm_Load(object sender, EventArgs e)
        {
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    RefreshDgvNastavnik();
                    break;

                case 3:
                    RefreshDgvAdmin();
                    break;

                case 4:
                    RefreshDgvSuperadmin();
                    break;

                default:
                    break;
            }
            
        }

        private void izbrisiUcenikaButton_Click(object sender, EventArgs e)
        {
            korisnikUcenikView odabranUcenik = dgvPopisUcenika.CurrentRow.DataBoundItem as korisnikUcenikView;
            bool izbrisan = RepozitorijKviz.IzbrisiOdabranogUcenika(odabranUcenik);

            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    RefreshDgvNastavnik();
                    break;

                case 3:
                    RefreshDgvAdmin();
                    break;

                case 4:
                    RefreshDgvSuperadmin();
                    break;

                default:
                    break;
            }

            if(izbrisan == true)
            {
                MessageBox.Show("Učenik je uspješno izbrisan!");
            }
        }

        private void dodajUcenikaButton_Click(object sender, EventArgs e)
        {
            DodajUcenikaForm dodajUcenikaForm = new DodajUcenikaForm(ulogiraniKorisnik);
            dodajUcenikaForm.ShowDialog();

            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    RefreshDgvNastavnik();
                    break;

                case 3:
                    RefreshDgvAdmin();
                    break;

                case 4:
                    RefreshDgvSuperadmin();
                    break;

                default:
                    break;
            }
        }

        private void RefreshDgvSuperadmin()
        {
            List<korisnikUcenikView> sviUceniciUlogiranogSuperadmina = RepozitorijKviz.SviUceniciUlogiranogSuperadmina();
            PopuniDgvPopis(sviUceniciUlogiranogSuperadmina);
        }

        private void RefreshDgvAdmin()
        {
            List<korisnikUcenikView> sviUceniciUlogiranogAdmina = RepozitorijKviz.DohvatiUcenikeUlogiranogAdmina(ulogiraniKorisnik);
            PopuniDgvPopis(sviUceniciUlogiranogAdmina);
        }

        private void RefreshDgvNastavnik()
        {
            List<korisnikUcenikView> sviUceniciUlogiranogNastavnika = RepozitorijKviz.DohvatiUcenikeUlogiranogNastavnika(ulogiraniKorisnik);
            PopuniDgvPopis(sviUceniciUlogiranogNastavnika);
        }

        private void PopuniDgvPopis(List<korisnikUcenikView> sviUceniciUlogiranog)
        {
            dgvPopisUcenika.DataSource = sviUceniciUlogiranog;
        }

        private void povratakNaPocetnuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopisUcenikaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:\\Users\\Valentina\\source\\repos\\pi21-vtucelj20-icuturic20-ipeles\\Software\\Repozitorij\\Pomoc.chm", HelpNavigator.Topic, "pregledavanjeUcenika.htm");
        }
    }
}

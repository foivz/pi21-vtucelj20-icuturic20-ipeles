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
    public partial class IzborKvizaZaPregledForm : Form
    {
        korisnik ulogiraniKorisnik;
        public IzborKvizaZaPregledForm(korisnik logirani)
        {
            ulogiraniKorisnik = logirani;
            InitializeComponent();
        }

        private void IzborKvizaZaPregledForm_Load(object sender, EventArgs e)
        {
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    skolaLabel.Visible = false;
                    skolaComboBox.Visible = false;
                    razredComboBox.DataSource = RepozitorijKviz.DohvatiRazredeNastavnika(ulogiraniKorisnik);
                    break;

                case 3:
                    skolaComboBox.DataSource = RepozitorijKviz.DohvatiSveSkoleAdmina(ulogiraniKorisnik);
                    break;

                case 4:
                    skolaComboBox.DataSource = RepozitorijKviz.DohvatiSveSkole();
                    break;

                default:
                    break;
            }           
        }

        private void razredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    predmetComboBox.DataSource = null;
                    predmetComboBox.DataSource = RepozitorijKviz.DohvatiSvePredmeteRazreda(ulogiraniKorisnik, razredComboBox.Text);
                    break;

                case 3:
                    predmetComboBox.DataSource = null;
                    predmetComboBox.DataSource = RepozitorijKviz.DohvatiSvePredmeteRazredaSkole(razredComboBox.Text, skolaComboBox.Text);
                    break;

                case 4:
                    predmetComboBox.DataSource = null;
                    predmetComboBox.DataSource = RepozitorijKviz.DohvatiSvePredmeteRazredaSkole(razredComboBox.Text, skolaComboBox.Text);
                    break;

                default:
                    break;
            }
        }

        private void predmetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    cjelinaComboBox.DataSource = null;
                    cjelinaComboBox.DataSource = RepozitorijKviz.DohvatiCjelinePredmeta(ulogiraniKorisnik, razredComboBox.Text, predmetComboBox.Text);
                    break;

                case 3:
                    cjelinaComboBox.DataSource = null;
                    cjelinaComboBox.DataSource = RepozitorijKviz.DohvatiCjelinePredmetaRazredaSkole(razredComboBox.Text, predmetComboBox.Text, skolaComboBox.Text);
                    break;

                case 4:
                    cjelinaComboBox.DataSource = null;
                    cjelinaComboBox.DataSource = RepozitorijKviz.DohvatiCjelinePredmetaRazredaSkole(razredComboBox.Text, predmetComboBox.Text, skolaComboBox.Text);
                    break;

                default:
                    break;
            }
        }

        private void cjelinaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kvizComboBox.DataSource = null;
            kvizComboBox.DataSource = RepozitorijKviz.DohvatiIspite(razredComboBox.Text, predmetComboBox.Text, cjelinaComboBox.Text);
        }

        private void skolaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            razredComboBox.DataSource = null;
            razredComboBox.DataSource = RepozitorijKviz.DohvatiSveRazredeSkole(skolaComboBox.Text);
        }

        private void pregledajButton_Click(object sender, EventArgs e)
        {
            ispit odabranKviz = new ispit();
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    odabranKviz = RepozitorijKviz.DohvatiOdabranKvizNastavnik(ulogiraniKorisnik, razredComboBox.Text, predmetComboBox.Text, cjelinaComboBox.Text, kvizComboBox.Text);                   
                    break;

                case 3:
                    odabranKviz = RepozitorijKviz.DohvatiOdabranKviz(skolaComboBox.Text, razredComboBox.Text, predmetComboBox.Text, cjelinaComboBox.Text, kvizComboBox.Text);
                    break;

                case 4:
                    odabranKviz = RepozitorijKviz.DohvatiOdabranKviz(skolaComboBox.Text, razredComboBox.Text, predmetComboBox.Text, cjelinaComboBox.Text, kvizComboBox.Text);
                    break;

                default:
                    break;
            }

            PregledPitanjaForm pregledPitanjaForm = new PregledPitanjaForm(ulogiraniKorisnik, odabranKviz, cjelinaComboBox.Text);
            pregledPitanjaForm.ShowDialog();
            this.Close();
        }
    }
}

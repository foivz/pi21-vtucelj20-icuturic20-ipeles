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
    public partial class GlavnaPocetnaForm : Form
    {
        korisnik ulogiraniKorisnik;
        public GlavnaPocetnaForm(korisnik logirani)
        {
            ulogiraniKorisnik = logirani;
            InitializeComponent();
        }

        private void GlavnaPocetnaForm_Load(object sender, EventArgs e)
        {
            
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    pregledajNastavnikeButton.Visible = false;
                    dodajSkoluButton.Visible = false;
                    break;

                case 3:
                    dodajSkoluButton.Visible = false;
                    break;

                case 4:
                    break;

                default:
                    break;
            }
        }

        private void rjesavajKvizButton_Click(object sender, EventArgs e)
        {
            switch (ulogiraniKorisnik.tip_id)
            {
                case 2:
                    int idSkole = RepozitorijKviz.DohvatiIdSkoleZaNastavnika(ulogiraniKorisnik);
                    UcenikPocetnaForm ucenikPocetnaForm = new UcenikPocetnaForm(ulogiraniKorisnik, idSkole);
                    ucenikPocetnaForm.ShowDialog();
                    break;

                case 3:
                    int idSkoleAdmin = RepozitorijKviz.DohvatiIdSkoleZaAdmina(ulogiraniKorisnik);
                    UcenikPocetnaForm ucenikPocetnaFormAdmin = new UcenikPocetnaForm(ulogiraniKorisnik, idSkoleAdmin);
                    ucenikPocetnaFormAdmin.ShowDialog();
                    break;

                case 4:
                    MessageBox.Show("Potrebno je ulogirati se s računom nekog od nastavnika ili admina iz baze!");
                    break;

                default:
                    break;
            }

            
        }

        private void pregledajUcenikeButton_Click(object sender, EventArgs e)
        {
            PopisUcenikaForm popisUcenikaForm = new PopisUcenikaForm(ulogiraniKorisnik);
            popisUcenikaForm.ShowDialog();
        }

        private void pregledajPitanjaButton_Click(object sender, EventArgs e)
        {
            IzborKvizaZaPregledForm izborKvizaZaPregledForm = new IzborKvizaZaPregledForm(ulogiraniKorisnik);
            izborKvizaZaPregledForm.ShowDialog();
        }
    }
}

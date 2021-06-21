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

namespace Projekt
{
    public partial class PrijavaForm : Form
    {
        korisnik logiraniKorisnik;
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void ucenikBbutton_Click(object sender, EventArgs e)
        {
            
            using (var context = new KvizModelEntities()) {
                var query = from k in context.korisnici
                            where k.korisnicko_ime == "testUcenik" && k.lozinka == "nekalozinka5"
                            select k;
                logiraniKorisnik = query.Single();
            }

            UcenikPocetnaForm ucenikPocetnaForm = new UcenikPocetnaForm(logiraniKorisnik);
            ucenikPocetnaForm.ShowDialog();
        }

        private void nastavnikButton_Click(object sender, EventArgs e)
        {
            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            where k.korisnicko_ime == "brantuc1" && k.lozinka == "kivi45"
                            select k;
                logiraniKorisnik = query.Single();
            }

            GlavnaPocetnaForm glavnaPocetnaForm = new GlavnaPocetnaForm(logiraniKorisnik);
            glavnaPocetnaForm.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            where k.korisnicko_ime == "marspernj" && k.lozinka == "mars123"
                            select k;
                logiraniKorisnik = query.Single();
            }

            GlavnaPocetnaForm glavnaPocetnaForm = new GlavnaPocetnaForm(logiraniKorisnik);
            glavnaPocetnaForm.ShowDialog();
        }

        private void superadminButton_Click(object sender, EventArgs e)
        {
            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            where k.korisnicko_ime == "vtucelj20" && k.lozinka == "admin_agent097"
                            select k;
                logiraniKorisnik = query.Single();
            }

            GlavnaPocetnaForm glavnaPocetnaForm = new GlavnaPocetnaForm(logiraniKorisnik);
            glavnaPocetnaForm.ShowDialog();
        }
    }
}

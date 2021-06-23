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
    public partial class UcenikPocetnaForm : Form
    {
        korisnik ulogiraniKorisnik;
        ispit odabranIspit;
        int dohvacenIdSkole;
        int dohvacenIdPredmeta;
        int odabranIdRazreda;
        int dohvacenIdCjeline;
        public UcenikPocetnaForm( korisnik logirani)
        {
            ulogiraniKorisnik = logirani;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcenikPocetnaForm_Load(object sender, EventArgs e)
        {
            
            using (var context = new KvizModelEntities())
            {
                //dohvaćanje razreda koji pripadaju istoj školi kao i prijavljeni korisnik/učenik
                var query = from k in context.korisnici
                            from r in context.razredi
                            where k.korisnik_id == ulogiraniKorisnik.korisnik_id && r.razred_id == ulogiraniKorisnik.razred_id
                            select r.skola_id;
                dohvacenIdSkole = query.Single();

                var query1 = from r in context.razredi
                             where r.skola_id == dohvacenIdSkole
                             select r.naziv_razreda;
                razredComboBox.DataSource = query1.ToList();
            }
        }

        private void razredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using(var context = new KvizModelEntities())
            {
                var query = from r in context.razredi
                            from p in r.predmet
                            where r.naziv_razreda == razredComboBox.Text && r.skola_id == dohvacenIdSkole
                            select p.naziv_predmeta;
                predmetComboBox.DataSource = query.ToList();

                var query1 = from ra in context.razredi
                             where ra.naziv_razreda == razredComboBox.Text && ra.skola_id == dohvacenIdSkole
                             select ra.razred_id;
                odabranIdRazreda = query1.Single();
            }
        }

        private void predmetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new KvizModelEntities())
            {
                var query1 = from p in context.predmeti
                             where p.naziv_predmeta == predmetComboBox.Text
                             select p.predmet_id;
                dohvacenIdPredmeta = query1.Single();

                var query = from c in context.cjeline
                            where c.razred_id == odabranIdRazreda && c.predmet_id == dohvacenIdPredmeta
                            select c.naziv_cjeline;
                cjelinaComboBox.DataSource = query.ToList();
            }
        }

        private void cjelinaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new KvizModelEntities())
            {
                var query = from c in context.cjeline
                            where c.naziv_cjeline == cjelinaComboBox.Text && c.predmet_id == dohvacenIdPredmeta && c.razred_id == odabranIdRazreda
                            select c.cjelina_id;
                dohvacenIdCjeline = query.Single();

                var query1 = from i in context.ispiti
                             where i.cjelina_id == dohvacenIdCjeline
                             select i.naziv_ispita;
                kvizComboBox.DataSource = query1.ToList();
            }
        }

        private void kreniButton_Click(object sender, EventArgs e)
        {
            using (var context = new KvizModelEntities())
            {
                var query = from i in context.ispiti
                            where i.naziv_ispita == kvizComboBox.Text && i.cjelina_id == dohvacenIdCjeline
                            select i;
                odabranIspit = query.Single();
            }

            RjesavanjeKvizaForm rjesavanjeKvizaForm = new RjesavanjeKvizaForm(ulogiraniKorisnik, odabranIspit);
            rjesavanjeKvizaForm.ShowDialog();
        }
    }
}

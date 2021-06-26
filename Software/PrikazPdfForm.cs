using Projekt.Entities;
using Projekt.Repozitorij;
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
    public partial class PrikazPdfForm : Form
    {
        korisnik ulogiraniKorisnik;
        ispit odabranKviz;
        public PrikazPdfForm(korisnik ulogiran, ispit odabran)
        {
            ulogiraniKorisnik = ulogiran;
            odabranKviz = odabran;
            InitializeComponent();
        }

        private void PrikazPdfForm_Load(object sender, EventArgs e)
        {
            korisnikBindingSource.DataSource = ulogiraniKorisnik;
            ispitBindingSource.DataSource = odabranKviz;
            List<SlanjeRezultataView> sviOdgovori = new List<SlanjeRezultataView>();

            using (var context = new KvizModelEntities())
            {
                var query = from c in context.cjeline
                            from i in context.ispiti
                            where i.ispit_id == odabranKviz.ispit_id && i.cjelina_id == c.cjelina_id
                            select c;
                cjelinaBindingSource.DataSource = query.Single();

                var query1 = from i in context.izabrao
                             where i.korisnik_id == ulogiraniKorisnik.korisnik_id && i.ispit_id == odabranKviz.ispit_id
                             select i;
                izabraoBindingSource.DataSource = query1.ToList().Last();
                izabrao zaUsporedbuVremena = query1.ToList().Last();

                var query2 = from p in context.pitanja
                             where p.ispit_id == odabranKviz.ispit_id
                             select p;
                List<pitanje> svaPitanja = query2.ToList();

                foreach (var pitanje in svaPitanja)
                {
                    var query3 = from d in context.dani_odgovori
                                 from po in context.ponudeni_odgovori
                                 where d.korisnik_id == ulogiraniKorisnik.korisnik_id && d.ponudeni_odgovor_id == po.ponudeni_odgovor_id && po.pitanje_id == pitanje.pitanje_id && d.datum_vrijeme > zaUsporedbuVremena.datum_vrijeme_od
                                 select new SlanjeRezultataView
                                 {
                                     tekst_pitanja = pitanje.tekst_pitanja,
                                     dan_odgovor = po.tekst_odgovora,
                                     tocan = po.tocan
                                 };
                    SlanjeRezultataView novi = query3.Single();
                    sviOdgovori.Add(novi);
                }

                SlanjeRezultataViewBindingSource.DataSource = sviOdgovori;
            }

            this.pdfReportViewer.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void pdfReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}

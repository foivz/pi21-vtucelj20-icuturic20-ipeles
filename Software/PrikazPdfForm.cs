using Microsoft.Reporting.WinForms;
using Projekt.Entities;
using Projekt.Repozitorij;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
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
           
        }

        private void pdfReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string fileNameExt;
            string deviceInfo = "<DeviceInfo>" +
                " <OutputFormat>PDF</OutputFormat>" +
                " <PageWidth>8.27in</PageWidth>" +
                " <PageHeight>11.69in</PageHeight>" +
                " <MarginTop>0.25in</MarginTop>" +
                " <MarginLeft>0.4in</MarginLeft>" +
                " <MarginRight>0in</MarginRight>" +
                " <MarginBottom>0.25in</MarginBottom>" +
                " <EmbedFonts>None</EmbedFonts>" +
                "</DeviceInfo>";

            byte[] bytes = pdfReportViewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out fileNameExt, out streamids, out warnings);
            using (FileStream fs = new FileStream("rezultati.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            SmtpClient klijent = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential cred = new NetworkCredential("tinatucelj@gmail.com", "MsVtan7!!");

            //mail učeniku
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("tinatucelj@gmail.com");
            msg.To.Add(ulogiraniKorisnik.mail);
            msg.Subject = "Rezultat i odgovori";
            msg.Body = $"Poštovani/a {ulogiraniKorisnik.ime} {ulogiraniKorisnik.prezime},\n\n" +
                $"u privitku su Vaši odgovori i rezultat!\n\n" +
                $"Veselimo se Vašem daljnjem učenju i rješavanju.\n\n" +
                $"Kvisko tim";
            Attachment pdf = new Attachment("rezultati.pdf", MediaTypeNames.Application.Octet);
            msg.Attachments.Add(pdf);
            klijent.Credentials = cred;
            klijent.EnableSsl = true;
            klijent.Send(msg);

            //mail nastavniku
            MailMessage msg1 = new MailMessage();
            msg1.From = new MailAddress("tinatucelj@gmail.com");
            msg1.To.Add(ulogiraniKorisnik.mail);
            msg1.Subject = "Rezultat i odgovori";

            korisnik nastavnik;
            using (var context = new KvizModelEntities()) 
            {
                var query = from p in context.pitanja
                            from k in context.korisnici
                            where p.ispit_id == odabranKviz.ispit_id && p.kreirao_korisnik_id == k.korisnik_id
                            select k;
                nastavnik = query.ToList().Last();
            }

            msg1.Body = $"Poštovani/a {nastavnik.ime} {nastavnik.prezime},\n\n" +
                $"u privitku su odgovori i rezultat za učenika {ulogiraniKorisnik.ime} {ulogiraniKorisnik.prezime}!\n" +
                $"\n" +
                $"Kvisko tim";
            Attachment pdf1 = new Attachment("rezultati.pdf", MediaTypeNames.Application.Octet);
            msg1.Attachments.Add(pdf1);
            klijent.Credentials = cred;
            klijent.EnableSsl = true;
            klijent.Send(msg1);

            this.Close();
        }
    }
}

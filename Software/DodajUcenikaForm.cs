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
using System.Net.Mail;
using System.Net;

namespace Projekt
{
    public partial class DodajUcenikaForm : Form
    {
        korisnik ulogiraniKorisnik;
        public DodajUcenikaForm(korisnik ulogirani)
        {
            ulogiraniKorisnik = ulogirani;
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajUcenikaForm_Load(object sender, EventArgs e)
        {
            skolaComboBox.DataSource = RepozitorijKviz.DohvatiSkoleUlogiranogNastavnika(ulogiraniKorisnik);
        }

        private void skolaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            razredComboBox.DataSource = RepozitorijKviz.DohvatiRazredeOdabraneSkole(skolaComboBox.Text);
        }

        private void generirajKorImeButton_Click(object sender, EventArgs e)
        {
            if(imeTextBox.Text == "" || prezimeTextBox.Text == "")
            {
                MessageBox.Show("Potrebno je upisati i ime i prezime!");
            } else
            {
                korImeTextBox.Text = Generator.GenerirajKorisnickoIme(imeTextBox.Text, prezimeTextBox.Text);
            }
        }

        private void generirajLozinkuButton_Click(object sender, EventArgs e)
        {
            lozinkaTextBox.Text = Generator.GenerirajLozinku();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            bool provjera = ProvjeriUnos();
            if(provjera == true)
            {
                korisnikUcenikView noviUcenik = new korisnikUcenikView
                {
                    ime = imeTextBox.Text,
                    prezime = prezimeTextBox.Text,
                    mail = mailTextBox.Text,
                    adresa = adresaTextBox.Text,
                    postanski_broj = Int32.Parse(postanskiTextBox.Text),
                    korisnicko_ime = korImeTextBox.Text,
                    lozinka = lozinkaTextBox.Text,
                    naziv_skole = skolaComboBox.Text,
                    naziv_razreda = razredComboBox.Text
                };

                int brojObuhvacenihRedova = RepozitorijKviz.DodajNovogUcenika(noviUcenik);
                if(brojObuhvacenihRedova > 0)
                {
                    //slanje maila učeniku sa njegovim pristupnim podacima
                    SmtpClient klijent = new SmtpClient("smtp.gmail.com", 587);
                    NetworkCredential cred = new NetworkCredential("tinatucelj@gmail.com", "MsVtan7!!");
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("tinatucelj@gmail.com");
                    msg.To.Add(noviUcenik.mail);
                    msg.Subject = "Pristupni podaci za Kvisko";
                    msg.Body = $"Poštovani/a {noviUcenik.ime} {noviUcenik.prezime},\n\n" +
                        $"pristupni podaci za aplikaciju Kvisko su: \n" +
                        $"     Korisničko ime: {noviUcenik.korisnicko_ime}\n" +
                        $"     Lozinka: {noviUcenik.lozinka}\n\n" +
                        $"Sretno s kvizovima :)";
                    klijent.Credentials = cred;
                    klijent.EnableSsl = true;
                    klijent.Send(msg);

                    MessageBox.Show("Učenik je dodan!", "Uspješno dodavanje");

                    this.Close();

                } else
                {
                    MessageBox.Show("Učenik nije dodan!", "Poruka o grešci");
                }
            }
            else
            {
                MessageBox.Show("Neki podaci nisu popunjeni ili korisničko ime već postoji u bazi!", "Poruka o grešci");
            }
        }

        private bool ProvjeriUnos()
        {
            bool dobarUnos = true;

            if(imeTextBox.Text == "" || prezimeTextBox.Text == "" || mailTextBox.Text == "" || adresaTextBox.Text == "" || postanskiTextBox.Text == "" || korImeTextBox.Text == "" || lozinkaTextBox.Text == "" || skolaComboBox.Text == "" || razredComboBox.Text == "")
            {
                dobarUnos = false;
            } else if(RepozitorijKviz.ProvjeraSlobodnogKorisnickogImena(korImeTextBox.Text) == false)
            {
                dobarUnos = false;
                MessageBox.Show("Korisničko ime već postoji!", "Poruka o grešci");
            }

            return dobarUnos;
        }
    }
}

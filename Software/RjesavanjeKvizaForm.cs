using Microsoft.Reporting.WinForms;
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
    public partial class RjesavanjeKvizaForm : Form
    {
        korisnik ulogiraniKorisnik;
        ispit odabranKviz;
        ponudeni_odgovor odabranOdgovor;
        int brojacPitanja = 0;
        List<pitanje> svaPitanja;
        List<ponudeni_odgovor> ponudeniOdgovori;
        
        public RjesavanjeKvizaForm(korisnik logirani, ispit odabrani)
        {
            InitializeComponent();
            ulogiraniKorisnik = logirani;
            odabranKviz = odabrani;
        }

        private void RjesavanjeKvizaForm_Load(object sender, EventArgs e)
        {
            RepozitorijKviz.SpremiTrenutniPokusajRjesavanja(ulogiraniKorisnik, odabranKviz);
            
            //prikaži prvo pitanje i odgovore
            svaPitanja = RepozitorijKviz.DohvatiSvaPitanja(odabranKviz);
            PopuniPitanjeIOdgovore(svaPitanja, brojacPitanja);
            brojacPitanja++;
        }

        private void prijaviKrivoPitanjeButton_Click(object sender, EventArgs e)
        {
            PrijavaKrivogPitanjaForm prijavaKrivogPitanjaForm = new PrijavaKrivogPitanjaForm();
            prijavaKrivogPitanjaForm.ShowDialog();
        }

        private void sljedecePitanjeButton_Click(object sender, EventArgs e)
        {

            if (NijeOdabranNijedanOdgovor() == true) {

                MessageBox.Show("Niste odabrali nijedan odgovor!");

            } else {
                
                RepozitorijKviz.SpremiDanOdgovorUBazu(ulogiraniKorisnik, odabranOdgovor);
                OcistiRadioButtone();

                if (brojacPitanja == -1)
                {
                    //update datum_vrijeme_do u tablici 'izabrao' da znamo kad je kviz završio -->ovo ne radi???????
                    //RepozitorijKviz.UpdateVremenaZavrsetkaKviza(ulogiraniKorisnik, odabranKviz);
                    

                    //došli smo do kraja --> prikaži rezultat i pošalji pdf učeniku i zaduženom nastavniku
                    PrikazPdfForm prikazPdfForm = new PrikazPdfForm(ulogiraniKorisnik, odabranKviz);
                    prikazPdfForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    if (svaPitanja[brojacPitanja] == svaPitanja.Last())
                    {
                        PopuniPitanjeIOdgovore(svaPitanja, brojacPitanja);

                        //brojacPitanja postaviti na -1 da u sljedećem prolazu (kliku na Sljedeće pitanje) znamo da je obrađeno zadnje pitanje
                        brojacPitanja = -1;
                    }
                    else
                    {
                        PopuniPitanjeIOdgovore(svaPitanja, brojacPitanja);

                        brojacPitanja++;
                    }
                }
            } 
        }

        private bool NijeOdabranNijedanOdgovor()
        {
            if(radioButton1.Checked == true) {
                odabranOdgovor = ponudeniOdgovori[0];
                return false;

            } else if(radioButton2.Checked == true) {
                odabranOdgovor = ponudeniOdgovori[1];
                return false;

            } else if(radioButton3.Checked == true) {
                odabranOdgovor = ponudeniOdgovori[2];
                return false;

            } else if(radioButton4.Checked == true) {
                odabranOdgovor = ponudeniOdgovori[3];
                return false;

            } else {

                return true;
            }
        }

        private void PopuniPitanjeIOdgovore(List<pitanje> pitanja, int brojac)
        {
            pitanjeLabel.Text = pitanja[brojac].tekst_pitanja;
            ponudeniOdgovori = RepozitorijKviz.DohvatiOdgovoreNaPitanje(pitanja[brojac]);
            radioButton1.Text = ponudeniOdgovori[0].tekst_odgovora;
            radioButton2.Text = ponudeniOdgovori[1].tekst_odgovora;
            radioButton3.Text = ponudeniOdgovori[2].tekst_odgovora;
            radioButton4.Text = ponudeniOdgovori[3].tekst_odgovora;
        }

        private void OcistiRadioButtone()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void RjesavanjeKvizaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brojacPitanja != -1)
            {
                switch(MessageBox.Show("Još niste završili sa cijelim kvizom. Da li stvarno želite izaći?", "Želite li odustati?", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        e.Cancel = false;
                        break;

                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void RjesavanjeKvizaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:\\Users\\Valentina\\source\\repos\\pi21-vtucelj20-icuturic20-ipeles\\Software\\Repozitorij\\Pomoc.chm", HelpNavigator.Topic, "rjesavanjeKviza.htm");
        }
    }
}

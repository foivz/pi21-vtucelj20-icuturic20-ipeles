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
    public partial class DodajPitanjeForm : Form
    {
        korisnik ulogiranKorisnik;
        pitanjeOdgovoriView odabranoPitanje;
        public DodajPitanjeForm(korisnik ulogiran)
        {
            ulogiranKorisnik = ulogiran;
            InitializeComponent();
        }

        public DodajPitanjeForm(korisnik ulogiran, pitanjeOdgovoriView odabrano)
        {
            ulogiranKorisnik = ulogiran;
            odabranoPitanje = odabrano;
            InitializeComponent();
        }
    }
}

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
    }
}

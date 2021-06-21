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

        }
    }
}

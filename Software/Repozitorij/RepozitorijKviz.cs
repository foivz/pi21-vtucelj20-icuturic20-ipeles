using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Entities;

namespace Projekt.Repozitorij
{
    public static class RepozitorijKviz
    {
        public static List<pitanje> DohvatiSvaPitanja(ispit odabraniIspit) {
            List<pitanje> pitanja;

            using (var context = new KvizModelEntities())
            {
                var query = from p in context.pitanja
                            where p.ispit_id == odabraniIspit.ispit_id
                            select p;
                pitanja = query.ToList();
            }

            return pitanja;
        }

        public static List<ponudeni_odgovor> DohvatiOdgovoreNaPitanje(pitanje prvoPitanje)
        {
            List<ponudeni_odgovor> ponudeniOdgovori;

            using (var context = new KvizModelEntities())
            {
                var query = from po in context.ponudeni_odgovori
                            where po.pitanje_id == prvoPitanje.pitanje_id
                            select po;
                ponudeniOdgovori = query.ToList();
            }

            return ponudeniOdgovori;
        }

        public static void SpremiTrenutniPokusajRjesavanja(korisnik ulogiraniKorisnik, ispit odabraniKviz)
        {
            izabrao zaUnosUBazu = KreirajIzabraoZaUnosUBazu(ulogiraniKorisnik, odabraniKviz);
            using (var context = new KvizModelEntities())
            {
                context.izabrao.Add(zaUnosUBazu);
                context.SaveChanges();
            }
        }

        public static void SpremiDanOdgovorUBazu(korisnik ulogiraniKorisnik, ponudeni_odgovor odabranOdgovor)
        {
            dan_odgovor zaUbacivanjeUBazu = KreirajDanOdgovorZaUnosUBazu(ulogiraniKorisnik, odabranOdgovor);
            using (var context = new KvizModelEntities())
            {
                context.dani_odgovori.Add(zaUbacivanjeUBazu);
                context.SaveChanges();

            }
        }

        public static void UpdateVremenaZavrsetkaKviza(korisnik ulogiraniKorisnik, ispit odabranKviz)
        {
            using (var context = new KvizModelEntities())
            {
                izabrao zaUpdate = context.izabrao.ToList().Last(i => i.korisnik_id == ulogiraniKorisnik.korisnik_id && i.ispit_id == odabranKviz.ispit_id);
                zaUpdate.datum_vrijeme_do = DateTime.Now;
                context.SaveChanges();
            }
        }

        public static int DohvatiOstvareniRezultat(korisnik ulogiraniKorisnik, ispit odabranKviz)
        {
            int rezultatZaIspis;
            using (var context = new KvizModelEntities())
            {
                var query = from i in context.izabrao
                            where i.korisnik_id == ulogiraniKorisnik.korisnik_id && i.ispit_id == odabranKviz.ispit_id
                            select i.rezultat;
                rezultatZaIspis = query.ToList().Last();
            }

            return rezultatZaIspis;
        }

        public static int DohvatiIdSkoleZaNastavnika(korisnik ulogiraniKorisnik)
        {
            int idSkole;

            using (var context = new KvizModelEntities())
            {
                var query = from z in context.zaduzen_za
                            from r in context.razredi
                            where z.korisnik_id == ulogiraniKorisnik.korisnik_id && r.razred_id == z.razred_id
                            select r.skola_id;
                idSkole = query.ToList().First();
            }

            return idSkole;
        }

        public static int DohvatiIdSkoleZaAdmina(korisnik ulogiraniKorisnik)
        {
            int idSkole;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            where s.zaduzen_korisnik_admin == ulogiraniKorisnik.korisnik_id
                            select s.skola_id;
                idSkole = query.ToList().First();
            }

            return idSkole;
        }

        public static List<korisnikUcenikView> DohvatiUcenikeUlogiranogNastavnika(korisnik ulogiraniKorisnik)
        {
            List<korisnikUcenikView> sviUcenici;

            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            from z in context.zaduzen_za
                            from r in context.razredi
                            from s in context.skole
                            where k.status != 0 && z.korisnik_id == ulogiraniKorisnik.korisnik_id && z.razred_id == k.razred_id && r.razred_id == k.razred_id && s.skola_id == r.skola_id
                            select new korisnikUcenikView
                            {
                                korisnicko_ime = k.korisnicko_ime,
                                lozinka = k.lozinka,
                                mail = k.mail,
                                ime = k.ime,
                                prezime = k.prezime,
                                adresa = k.adresa,
                                postanski_broj = k.postanski_broj,
                                naziv_razreda = r.naziv_razreda,
                                naziv_skole = s.naziv_skole
                            };

                sviUcenici = query.ToList();
            }

            return sviUcenici;
        }

        public static List<korisnikUcenikView> DohvatiUcenikeUlogiranogAdmina(korisnik logirani)
        {
            List<korisnikUcenikView> sviUcenici;

            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            from s in context.skole
                            from r in context.razredi
                            where k.status != 0 && s.zaduzen_korisnik_admin == logirani.korisnik_id && r.skola_id == s.skola_id && k.razred_id == r.razred_id
                            select new korisnikUcenikView
                            {
                                korisnicko_ime = k.korisnicko_ime,
                                lozinka = k.lozinka,
                                mail = k.mail,
                                ime = k.ime,
                                prezime = k.prezime,
                                adresa = k.adresa,
                                postanski_broj = k.postanski_broj,
                                naziv_razreda = r.naziv_razreda,
                                naziv_skole = s.naziv_skole
                            };

                sviUcenici = query.ToList();
            }

            return sviUcenici;
        }

        public static List<korisnikUcenikView> SviUceniciUlogiranogSuperadmina()
        {
            List<korisnikUcenikView> sviUcenici;

            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            from r in context.razredi
                            from s in context.skole
                            where k.status !=0 && k.razred_id != null && r.razred_id == k.razred_id && r.skola_id == s.skola_id
                            select new korisnikUcenikView
                            {
                                korisnicko_ime = k.korisnicko_ime,
                                lozinka = k.lozinka,
                                mail = k.mail,
                                ime = k.ime,
                                prezime = k.prezime,
                                adresa = k.adresa,
                                postanski_broj = k.postanski_broj,
                                naziv_razreda = r.naziv_razreda,
                                naziv_skole = s.naziv_skole
                            };

                sviUcenici = query.ToList();
            }

            return sviUcenici;
        }

        public static bool IzbrisiOdabranogUcenika(korisnikUcenikView odabran)
        {
            bool izbrisan = true;

            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            where k.korisnicko_ime == odabran.korisnicko_ime && k.lozinka == odabran.lozinka
                            select k;
                korisnik zaUpdate = query.Single();
                zaUpdate.status = 0;
                if (context.SaveChanges() == 0) {

                    izbrisan = false;
                }
            }

            return izbrisan;
        }

        public static List<string> DohvatiSkoleUlogiranogNastavnika(korisnik ulogirani)
        {
            List<string> listaSkola;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            from r in context.razredi
                            from z in context.zaduzen_za
                            where z.razred_id == r.razred_id && r.skola_id == s.skola_id
                            select s.naziv_skole;
                listaSkola = query.Distinct().ToList();
            }

            return listaSkola;
        }

        public static List<string> DohvatiRazredeOdabraneSkole(string skola)
        {
            List<string> listaRazreda;

            using (var context = new KvizModelEntities())
            {
                var query = from r in context.razredi
                            from s in context.skole
                            where s.naziv_skole == skola && r.skola_id == s.skola_id
                            select r.naziv_razreda;
                listaRazreda = query.ToList();
            }

            return listaRazreda;
        }

        public static int DodajNovogUcenika(korisnikUcenikView unesenUcenik)
        {
            int brojRedova = 0;
            int idRazreda;

            using(var context = new KvizModelEntities())
            {
                var query = from r in context.razredi
                            from s in context.skole
                            where r.naziv_razreda == unesenUcenik.naziv_razreda && s.naziv_skole == unesenUcenik.naziv_skole && r.skola_id == s.skola_id
                            select r.razred_id;
                idRazreda = query.Single();

                korisnik zaUnosUBazu = KreirajKorisnikaZaUnosUBazu( unesenUcenik, idRazreda);
                context.korisnici.Add(zaUnosUBazu);
                if(context.SaveChanges() != 0)
                {
                    brojRedova = 1;
                }               
            }
            return brojRedova;
        }

        public static bool ProvjeraSlobodnogKorisnickogImena(string korIme)
        {
            bool provjera = true;

            using (var context = new KvizModelEntities())
            {
                var query = from k in context.korisnici
                            where k.korisnicko_ime == korIme
                            select k;
                if(query.ToList().Count > 0)
                {
                    provjera = false;
                }
            }

            return provjera; 
        }

        private static korisnik KreirajKorisnikaZaUnosUBazu(korisnikUcenikView ucenik, int idRazreda)
        {
            korisnik zaUnosUBazu = new korisnik();
            zaUnosUBazu.ime = ucenik.ime;
            zaUnosUBazu.prezime = ucenik.prezime;
            zaUnosUBazu.korisnicko_ime = ucenik.korisnicko_ime;
            zaUnosUBazu.lozinka = ucenik.lozinka;
            zaUnosUBazu.mail = ucenik.mail;
            zaUnosUBazu.adresa = ucenik.adresa;
            zaUnosUBazu.postanski_broj = ucenik.postanski_broj;
            zaUnosUBazu.status = 1;
            zaUnosUBazu.tip_id = 1;
            zaUnosUBazu.razred_id = idRazreda;

            return zaUnosUBazu;
        }

        private static dan_odgovor KreirajDanOdgovorZaUnosUBazu(korisnik ulogiraniKorisnik, ponudeni_odgovor odabranOdgovor)
        {
            dan_odgovor zaUbacivanjeUBazu = new dan_odgovor();
            zaUbacivanjeUBazu.korisnik_id = ulogiraniKorisnik.korisnik_id;
            zaUbacivanjeUBazu.ponudeni_odgovor_id = odabranOdgovor.ponudeni_odgovor_id;
            zaUbacivanjeUBazu.datum_vrijeme = DateTime.Now;

            return zaUbacivanjeUBazu;
        }

        private static izabrao KreirajIzabraoZaUnosUBazu(korisnik ulogiraniKorisnik, ispit odabranKviz)
        {
            izabrao zaUnosUBazu = new izabrao();
            zaUnosUBazu.korisnik_id = ulogiraniKorisnik.korisnik_id;
            zaUnosUBazu.ispit_id = odabranKviz.ispit_id;
            zaUnosUBazu.datum_vrijeme_od = DateTime.Now;
            zaUnosUBazu.datum_vrijeme_do = null;
            zaUnosUBazu.rezultat = 0;

            return zaUnosUBazu;
        }
    }
}

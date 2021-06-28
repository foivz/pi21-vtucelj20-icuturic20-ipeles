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

        public static List<string> DohvatiRazredeNastavnika(korisnik ulogiraniKorisnik)
        {
            List<string> sviRazredi;

            using (var context = new KvizModelEntities())
            {
                var query = from z in context.zaduzen_za
                            from r in context.razredi
                            where z.korisnik_id == ulogiraniKorisnik.korisnik_id && z.razred_id == r.razred_id
                            select r.naziv_razreda;
                sviRazredi = query.Distinct().ToList();
            } 

                return sviRazredi;
        }

        public static List<string> DohvatiSvePredmeteRazreda(korisnik ulogiraniKorisnik, string odabranRazred)
        {
            List<string> sviPredmeti;

            using (var context = new KvizModelEntities())
            {
                var query = from z in context.zaduzen_za
                            from r in context.razredi
                            from p in r.predmet
                            where z.korisnik_id == ulogiraniKorisnik.korisnik_id && r.naziv_razreda == odabranRazred && z.razred_id == r.razred_id
                            select p.naziv_predmeta;
                sviPredmeti = query.Distinct().ToList();     
            }
            return sviPredmeti;
        }

        public static List<string> DohvatiSvePredmeteRazredaSkole(string odabranRazred, string odabaranaSkola)
        {
            List<string> sviPredmeti;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            from r in context.razredi
                            from p in r.predmet
                            where s.naziv_skole == odabaranaSkola && r.naziv_razreda == odabranRazred && r.skola_id == s.skola_id
                            select p.naziv_predmeta;
                sviPredmeti = query.Distinct().ToList();
            }
            return sviPredmeti;
        }

        public static List<string> DohvatiCjelinePredmeta(korisnik ulogiraniKorisnik, string odabranRazred, string odabranPredmet)
        {
            List<string> sveCjeline;

            using (var context = new KvizModelEntities())
            {
                var query = from z in context.zaduzen_za
                            from r in context.razredi
                            from p in context.predmeti
                            from c in context.cjeline
                            where z.korisnik_id == ulogiraniKorisnik.korisnik_id && r.naziv_razreda == odabranRazred && z.razred_id == r.razred_id && p.naziv_predmeta == odabranPredmet && c.predmet_id == p.predmet_id && c.razred_id == r.razred_id
                            select c.naziv_cjeline;
                sveCjeline = query.ToList();
            }

            return sveCjeline;
        }

        public static List<string> DohvatiCjelinePredmetaRazredaSkole(string odabranRazred, string odabranPredmet, string odabranaSkola)
        {
            List<string> sveCjeline;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            from r in context.razredi
                            from p in r.predmet
                            from c in context.cjeline
                            where s.naziv_skole == odabranaSkola && r.naziv_razreda == odabranRazred && r.skola_id == s.skola_id && p.naziv_predmeta == odabranPredmet && c.predmet_id == p.predmet_id && c.razred_id == r.razred_id
                            select c.naziv_cjeline;
                sveCjeline = query.ToList();
            }

            return sveCjeline;
        }

        public static List<string> DohvatiSveSkole()
        {
            List<string> sveSkole;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            select s.naziv_skole;
                sveSkole = query.ToList();
            }

            return sveSkole;
        }

        public static List<string> DohvatiSveSkoleAdmina(korisnik ulogiraniKorisnik)
        {
            List<string> sveSkole;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            where s.zaduzen_korisnik_admin == ulogiraniKorisnik.korisnik_id
                            select s.naziv_skole;
                sveSkole = query.ToList();
            }

            return sveSkole;
        }

        public static List<string> DohvatiIspite(string odabranRazred, string odabranPredmet, string odabranaCjelina)
        {
            List<string> sviIspiti;

            using (var context = new KvizModelEntities())
            {
                var query = from i in context.ispiti
                            from c in context.cjeline
                            from p in context.predmeti
                            from r in context.razredi
                            where r.naziv_razreda == odabranRazred && c.razred_id == r.razred_id && p.naziv_predmeta == odabranPredmet && c.predmet_id == p.predmet_id && c.naziv_cjeline == odabranaCjelina && i.cjelina_id == c.cjelina_id
                            select i.naziv_ispita;
                sviIspiti = query.ToList();
            }

            return sviIspiti;
        }

        public static List<string> DohvatiSveRazredeSkole(string odabranaSkola)
        {
            List<string> sviRazredi;

            using (var context = new KvizModelEntities())
            {
                var query = from r in context.razredi
                            from s in context.skole
                            where s.naziv_skole == odabranaSkola && r.skola_id == s.skola_id
                            select r.naziv_razreda;
                sviRazredi = query.ToList();
            }

            return sviRazredi;
        }

        public static List<pitanjeOdgovoriView> DohvatiPitanjaOdgovoreZaPregled(ispit odabran)
        {
            List<pitanjeOdgovoriView> svaPitanjaSOdgovorima = new List<pitanjeOdgovoriView>();
            List<ponudeni_odgovor> odgovori;
            List<pitanjeView> popisPitanja;
            ponudeni_odgovor tocan;

            using (var context = new KvizModelEntities())
            {
                var query = from p in context.pitanja
                            where p.ispit_id == odabran.ispit_id
                            select new pitanjeView
                            {
                                pitanje_id = p.pitanje_id,
                                pitanje_tekst = p.tekst_pitanja
                            };
                popisPitanja = query.ToList();
            }

            foreach (var pitanje in popisPitanja)
            {
                odgovori = null;
                tocan = null;

                using (var context = new KvizModelEntities())
                {
                    var query1 = from po in context.ponudeni_odgovori
                                 where po.pitanje_id == pitanje.pitanje_id
                                 select po;
                    odgovori = query1.ToList();

                }

                using (var context = new KvizModelEntities())
                {
                    var query2 = from po in context.ponudeni_odgovori
                                 where po.pitanje_id == pitanje.pitanje_id && po.tocan == 1
                                 select po;
                    tocan = query2.Single();
                }

                pitanjeOdgovoriView novi = new pitanjeOdgovoriView
                {
                    pitanje_id = pitanje.pitanje_id,
                    tekst_pitanja = pitanje.pitanje_tekst,
                    odg1_id = odgovori[0].ponudeni_odgovor_id,
                    odg1_tekst = odgovori[0].tekst_odgovora,
                    odg2_id = odgovori[1].ponudeni_odgovor_id,
                    odg2_tekst = odgovori[1].tekst_odgovora,
                    odg3_id = odgovori[2].ponudeni_odgovor_id,
                    odg3_tekst = odgovori[2].tekst_odgovora,
                    odg4_id = odgovori[3].ponudeni_odgovor_id,
                    odg4_tekst = odgovori[3].tekst_odgovora,
                    odgTocan_id = tocan.ponudeni_odgovor_id,
                    odgTocan_tekst = tocan.tekst_odgovora
                 };
                    
                svaPitanjaSOdgovorima.Add(novi);               
            }
            return svaPitanjaSOdgovorima;
        }

        public static ispit DohvatiOdabranKvizNastavnik(korisnik ulogiraniKorisnik, string odabranRazred, string odabranPredmet, string odabranaCjelina, string OdabranKviz)
        {
            ispit odabran;

            using (var context = new KvizModelEntities())
            {
                var query = from z in context.zaduzen_za
                            from r in context.razredi
                            from p in r.predmet
                            from c in context.cjeline
                            from i in context.ispiti
                            where z.korisnik_id == ulogiraniKorisnik.korisnik_id && z.razred_id == r.razred_id && r.naziv_razreda == odabranRazred && p.naziv_predmeta == odabranPredmet && c.predmet_id == p.predmet_id && c.razred_id == r.razred_id && i.cjelina_id == c.cjelina_id && c.naziv_cjeline == odabranaCjelina && i.naziv_ispita == OdabranKviz
                            select i;
                odabran = query.Single();
            }

            return odabran;
        }

        public static ispit DohvatiOdabranKviz(string odabranaSkola, string odabranRazred, string odabranPredmet, string odabranaCjelina, string OdabranKviz)
        {
            ispit odabran;

            using (var context = new KvizModelEntities())
            {
                var query = from s in context.skole
                            from r in context.razredi
                            from p in r.predmet
                            from c in context.cjeline
                            from i in context.ispiti
                            where s.naziv_skole == odabranaSkola && r.skola_id == s.skola_id && r.naziv_razreda == odabranRazred && p.naziv_predmeta == odabranPredmet && c.predmet_id == p.predmet_id && c.razred_id == r.razred_id && c.naziv_cjeline == odabranaCjelina && i.cjelina_id == c.cjelina_id && i.naziv_ispita == OdabranKviz
                            select i;
                odabran = query.Single();
            }

            return odabran;
        }

        public static int IzbrisiPitanjeIOdgovore(pitanjeOdgovoriView odabranRedak)
        {
            int provjera = 1;

            using (var context = new KvizModelEntities())
            {
                var query = from po in context.ponudeni_odgovori
                            where po.pitanje_id == odabranRedak.pitanje_id
                            select po;
                List<ponudeni_odgovor> zaBrisanjeOdgovori = query.ToList();
                foreach (var ponOdg in zaBrisanjeOdgovori)
                {
                    context.ponudeni_odgovori.Remove(ponOdg);
                    if(context.SaveChanges() == 0)
                    {
                        provjera = 0;
                    }
                    
                }

                var query1 = from p in context.pitanja
                             where p.pitanje_id == odabranRedak.pitanje_id
                             select p;
                pitanje zaBrisanjePitanje = query1.Single();
                context.pitanja.Remove(zaBrisanjePitanje);
                if(context.SaveChanges() == 0)
                {
                    provjera = 0;
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

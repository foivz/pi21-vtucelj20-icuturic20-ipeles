using System;
using System.Collections.Generic;
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
                izabrao zaUpdate = context.izabrao.ToList().Last(iz => iz.korisnik_id == ulogiraniKorisnik.korisnik_id && iz.ispit_id == odabranKviz.ispit_id);
                zaUpdate.datum_vrijeme_do = DateTime.UtcNow;
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

        private static dan_odgovor KreirajDanOdgovorZaUnosUBazu(korisnik ulogiraniKorisnik, ponudeni_odgovor odabranOdgovor)
        {
            dan_odgovor zaUbacivanjeUBazu = new dan_odgovor();
            zaUbacivanjeUBazu.korisnik_id = ulogiraniKorisnik.korisnik_id;
            zaUbacivanjeUBazu.ponudeni_odgovor_id = odabranOdgovor.ponudeni_odgovor_id;
            zaUbacivanjeUBazu.datum_vrijeme = DateTime.UtcNow;

            return zaUbacivanjeUBazu;
        }

        private static izabrao KreirajIzabraoZaUnosUBazu(korisnik ulogiraniKorisnik, ispit odabranKviz)
        {
            izabrao zaUnosUBazu = new izabrao();
            zaUnosUBazu.korisnik_id = ulogiraniKorisnik.korisnik_id;
            zaUnosUBazu.ispit_id = odabranKviz.ispit_id;
            zaUnosUBazu.datum_vrijeme_od = DateTime.UtcNow;
            zaUnosUBazu.datum_vrijeme_do = null;
            zaUnosUBazu.rezultat = 0;

            return zaUnosUBazu;
        }
    }
}

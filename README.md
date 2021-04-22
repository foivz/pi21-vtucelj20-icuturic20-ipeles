
# Kviz za provjeru znanja

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Valentina Tucelj | vtucelj20@foi.hr | 1191226283 | vtucelj20
Ivona Čuturić | icuturic20@foi.hr | 0162030492 | Ivona1987
Irena Peleš | ipeles@foi.hr | 0016133031 | irensi

## Opis domene
Učiteljima viših razreda osnovnih škola od velike bi pomoći bila aplikacija u koju bi sami unosili pitanja za pojedine cjeline nekog predmeta u jednom od razreda (5. – 8. razred) koja bi potom učenici rješavali kao kviz za provjeru znanja. Učenicima bi se pamtio svaki pokušaj rješavanja, ostvaren rezultat i dani odgovori. Učitelj/moderator bi mogao dodavati nova pitanja i nove cjeline te bi imao pregled statistika za pojedinog učenika ili za cijeli razred. Pitanja bi bila tipa točan samo jedan odgovor od 4 ponuđena. 

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava | Kod samog ulaska u aplikaciju potrebno je prijaviti se svojim korisnički imenom i lozinkom. Aplikacija sama prepoznaje da li se radi o učeniku, učitelju/moderatoru, adminu pojedine škole ili superadminu i sukladno tome im se otvara odgovarajuće sučelje. | Ivona Čuturić
F02 | Odabir razreda, predmeta i cjeline za rješavanje kviza | Učeniku se otvara sučelje za odabir razreda, predmeta iz tog razreda i cjeline tog predmeta. Po završetku odabira učenik može krenuti s rješavanjem kviza. | Ivona Čuturić
F03 | Rješavanje kviza | Otvara se pitanje po pitanje na kojima je potrebno odabrati jedan točan odgovor od 4 ponuđena. Svako pitanje nosi 1 bod ako je točno odgovoreno ili 0 ako je netočno. Nakon što učenik riješi kviz, oboje i učitelj i učenik dobiju mailom PDF datoteku sa svim pitanjima, odgovorima i rezultatima kviza.| Valentina Tucelj
F04 | Dodavanje/brisanje učenika | Moderator ima mogućnost dodavanja novih učenika, on im dodjeljuje korisničko ime i lozinku koje dobivaju mailom. | Valentina Tucelj
F05 | Dodavanje novih pitanja | Moderator ima mogućnost dodavanja nove cjeline  za pojedini predmet nekog razreda te potom i novih pitanja i odgovora. Isto tako može i samo odabrati već postojeću cjelinu i dodati nova pitanja i odgovore. | Irena Peleš
F06 | Pregled pitanja i odgovora uz mogućnost brisanja | Moderator može pogledati sva pitanja za pojedinu cjelinu (zajedno sa ponuđenim odgovorima i točnim odgovorima) te po potrebi može izbrisati ili izmijeniti neko pitanje ukoliko je krivo, isto tako i odgovore. | Valentina Tucelj
F07 | Dodavanje/brisanje moderatora/admina pojedine škole | Super admin može kreirati školu i njezinog administratora i šalje svakom dodanom korisniku (adminu, učitelju ili učeniku) mail sa pristupnim podacima. Admin pojedine škole ima mogućnost dodavanja ili brisanja učitelja/moderatora. | Irena Peleš
F08 | Pregled statistike | Moderator ima uvid u uspjeh pojedinog učenika ili cijelog razreda za neku cjelinu u obliku tablica, grafova i sa mogućnosti izvoza datoteke u PDF-u. | Ivona Čuturić
F09 | Prijava krivog pitanja | Učenik na svakom pitanju ima mogućnost prijave krivo postavljenog pitanja ili krivo ponuđenih odgovora. | Irena Peleš

## Tehnologije i oprema
.NET(Visual Studio), Word, MSSQL, Draw.io, GitHub, GitHub Classroom, Visual Paradigm

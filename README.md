<!-- ABOUT THE PROJECT -->
## O nalogi

Izdelajte razredni model za podjetje, ki se ubada z prevozi. Ustvarite abstrakten razred Prevoz in razrede Avtobusni Prevoz, Kombi Prevoz, AvtoPrevoz, ki dedujejo iz razreda Prevoz. Razredom dodajte vsaj tri poljubn atribute primemega tipa (npr. Vstop, Izstop, CenaVozovnice), pri čemer bodo razredi Avtobusni Prevoz, Kombi Prevoz in AvtoPrevoz imeli skupno vsaj 6 atributov (3 podedovane in vsak tri svoje unikatne). Upoštevajte tudi hierarhijo razredov. Držite se tudi pravil ograjevanja.

Ustvarite tudi razred UmikPrevozov, ki ima v sebi seznam objektov AvtobusniPrevoz, Kombi Prevoz in AvtoPrevoz.

V glavnem programu ustvarite nekaj primerkov posameznih razredov. Ustvarite vsaj 1 objekt UrnikPrevoz, vsaj 3 objekte AvtobusniPrevoz, vsaj 3 objekte Kombi Prevoz in vsaj 4 objekte Avtoprevaz

Pri ustvarjanju primerkov, uporabite in implementirajte za vsak razred vsaj dva različna konstruktorja. Razred UrnikPrevozov naj ima tudi metodo za iskanje prevozov, ki prejme vstopno in izstopno postajo vme pa vse prevoze, ki vključujejo omenjena mesta glede na vnesen seznam prevozov. V kolikor poizkusite poiskati prevoz, ki ne obstaja naj program sproži izjemo, ki javi, da navedena povezava ne obstaja.

Implementirajte še vsaj tri poljubne metode, ki so smiselne in ne preenostavne.

Implementirajte tudi metodo, ki omogoča uvoz objelda UmikPrevozov iz poljubne datoteke (lahko npr. csv).

Poskrbite tudi, da boste demonstrirali vse implementirane metode in veljavne kot tudi neveljavne vrednosti (v primeru proženja izjem), izjeme ustrezno obravnavajte, da ne povzročijo sesutja glavnega programa Poskrbite za izpise tako da preobložite (overloading) metodo toString v posameznih razredih



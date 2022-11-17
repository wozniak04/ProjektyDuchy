if not exists (select 1 from dbo.[Duchy])
begin
	INSERT INTO [dbo].[Duchy] (Nazwa,Opis,Slabosc,Moc,Dowody)
	values 
	(
	'Spirit',
	'Spirit to bardzo powszechy duch. Jest 
bardzo potężny, ale pasywny, atakuje 
tylko wtedy, gdy musi. W największym 
stopniu broni swojego miejsca śmierci, 
zabijając każdego kto zostanie 
przyłapany na nadmiernej gościnności.',
'Użycie kadzidła w pokoju powstrzyma ducha przed atakowaniem na dłuższy czas.',
'Nie ma żadnych specjalnych mocy',
'EMF poziom 5,Spirit Box,Pismo ducha'
),
(
	'Wraith',
	'Wraith to jeden z najniebezpieczniejszych 
duchów jakie napotkasz. Jest to również 
jedyny byt, który potrafi lewitować i 
czasami przenika przez ściany.',
'Wraith prawie nigdy nie dotykają ziemi, co oznacza, że nie można ich śledzić poprzez odciski stóp.',
'Sól działa na Wraith negatywnie.',
'EMF poziom 5,Spirit Box,Projektor D.O.T.S'
),
(
	'Fantom',
	'Fantom to rodzaj ducha, który może opętać 
żywą istotę. Najczęściej jest przywoływany 
przez tabliczkę Ouija. Wzbudza również 
strach w ludziach otaczających go.',
'Patrzenie na Fantoma znacznie obniży Twoje zdrowie psychiczne.',
'Sfotografowanie Fantoma sprawi że tymczasowo zniknie.',
'EMF poziom 5,Odciski palców,Projektor D.O.T.S'
),
(
	'Poltergeist',
	'Jeden z najsłynniejszych rodzajów duchów, 
Poltergeist, znany również jako hałaśliwa 
istota, może manipulować obiektami wokół, 
aby wzbudzać strach w swoich ofiarach.',
'Poltergeist może rzucać wieloma przedmiotamy z potężną siłą.',
'Poltergeist jest mało skuteczny w pustych pomieszczeniach.',
'Odciski palców,Spirit Box,Pismo ducha'
),
(
	'Banshee',
	'Śpiewająca syrena, znana z tego, że 
śpiewem wabi swoje ofiary. Wiadomo, żę 
wybiera konkretną ofiarę, zanim zadaje 
śmiertelny cios.',
'Banshee osłabi swój cel przed atakiem.',
'Krzyki Banshee słychać czasami przy użyciu mikrofonu parabolicznego.',
'Odciski palców,Orb,Projektor D.O.T.S'
),
(
	'Jinn',
	'Jinn jest duchem terytorialnym, który
zaatakuje, gdy poczuje się zagrożony
Wiadomo nam, że może się przemieszczać z 
ogromną prędkością.',
'Jinn będzie poruszał się szybciej gdy jego ofiara jest daleko.',
'Wyłączenie źródła zasilania powstrzyma Jinna przed użyciem jego umiejętności.',
'EMF poziom 5,Odciski palców,Mroźne temperatury'
),
(
	'Mara',
	'Mara jest źródłem wszystkich koszmarów
czyniąc ją potężniejszą w ciemności.',
'Istnieje duże prawdopodobieństwo, że Mara zaatakuje w mroku.',
'Włączenie światła w jej otoczeniu zmniejszy szansę na atak.',
'Spirit Box,Orb,Pismo ducha'
),
(
	'Revenant',
	'Revenant to brutalny duch, który atakuje
bezkrytycznie. Jego prędkość może być myląca, 
ponieważ są powolne, gdy są uśpione, jednak
gdy tylko zacznie polować, może poruszać się
niesamowicie szybko.',
'Prędkość Revenanta zwiększa się gdy atakuję ofiarę.',
'Ukrycie się przed nim sprawi, żę będzie wolniejszy.',
'Orb,Pismo ducha,Mroźne temperatury'
),
(
	'Shade',
	'Shade znany jest również jako nieśmiały 
duch. Istnieją dowody na to, że Shade 
zatrzyma wszelkie paranormalne zjawisko 
jeśli w pobliżu znajduje się więcej ludzi.',
'Shade jest o wiele trudniejszy do znalezienia.',
'Shade nie zacznie atakować jeśli w pobliżu ktoś się znajduje.',
'EMF poziom 5,Pismo ducha,Mroźne temperatury'
),
(
	'Demon',
	'Demon to najbardziej agresywny duch,
jaki kiedykolwiek napotkaliśmy. Znane z
tego, że atakują bez powodu, wydają się
czerpać przyjemność z polowania.',
'Demony inicjują polowania częściej niż inne duchy.',
'Demony boją isę krucyfiksu i będą mniej agrysywne w jego pobliżu.',
'Odciski palców,Pismo ducha,Mroźne temperatury'
),
(
	'Yurei',
	'Yurei to rodzaj ducha który powrócił do
fizycznego świata, zazwyczaj z nienawiści 
lub w celu zemsty.',
'Yurei jest znany z wywierania silnego wpływu na ludzką psychikę.',
'Zapalanie kadzidła w pookju Yurei powoduje, że nie błąka się po lokacji przez dłuższy czas.',
'Orb,Mroźne temperatury,Projektor D.O.T.S'
),
(
	'Oni(tka)',
	'Oni(tka) uwielbia straszyć swoje ofiary tak
bardzo, jak to tylko możliwe, zanim zaatakują.
Często widuje się je w sowjej fizycznej 
postaci, strzegące miejsca śmierci.',
'Oni(tka) jest bardziej aktywny jeśli w pobliżu są ludzie i iszytbciej pozbawia ich psychiki podczas manifestowania się.',
'Oni(tka) znika o wiele rzadziej podczas polowania.',
'EMF poziom 5,Mroźne temperatury,Projektor D.O.T.S'
),
(
	'Yokai',
	'Yokai to pospolity typ ducha, którego
przyciąga ludzki głos. Zwykle można go
spotkać w domach rodzinnych.',
'Rozmowa w jego pobliżu zdenerwuje go i zwiększy szansę na atak.',
'Podczas nawiedzania słyszy tylko najbliższy głos.',
'Spirit Box,Orb,Projektor D.O.T.S'
),
(
	'Hantu',
	'Hantu to rzadki duch, który żyje w
najzimniejszym klimacie. Wydaje się, że 
zimno czyni go bardziej agrysywnym i wzmocnionym.',
'Niższe temperatury powodują szybsze poruszanie się Hantu.',
'Hantu będzie poruszać się wolniej w cieplejszych obszarach.',
'Odciski palców,Orb,Mroźne temperatury'
),
(
	'Goryo',
	'Goryo to przebiegły duch, który może 
zostać ujawniony przez światło laserowe 
tylko kiedy jest ogladany przez kamerę.',
'Goryo zwykle widoczny jest przez aparat tylko wtedy, gdy w pobliżu nie ma ludzi.',
'Rzadko widuje się go z dala od miejsca śmierci.',
'EMF poziom 5,Odciski palców,Projektor D.O.T.S'
),
(
	'Myling',
	'Myling to bardzo głośny i aktywny duch.
Plotki mówią, że podczas polowania na
zdobyc zachowują się cicho.',
'Myling znany jest z cichego zachowania podczas polowania.',
'Myling cześciej wydjae paranormalne dźwięki.',
'EMF poziom 5,Odciski palców,Pismo ducha'
),
(
	'Onryo',
	'Onryo jest często określany jako ,,Gniewny
Duch". Kradnie dusze z ciał umierających
ofiar w poszukiwaniu zemsty. Wiadomo, że
ten duch boi się każdej formy ognia i zrobi
wszystko, aby być jak najdalej od niego.',
'Zgaszenie płomienia może spowodować atak Onryo.',
'Gdy jest zagrożony, ten duch będzie mniej skłonny do polowania.',
'Spirit Box,Orb,Mroźne temperatury'
),
(
	'Twins',
	'Doniesiono że te duchy naśladują 
nawzajem swoje działania. Atakują na
przemian, aby zmylić zdobycz.',
'Każdy z bliźniaków może się rozgniewać i zaatakować swoją ofiarę.',
'Często wchodzą w interakcję z otoczeniem w tym samym czasie.',
'EMF poziom 5,Spirit Box,Mroźne temperatury'
),
(
	'Raiju',
	'Raiju to demon, który żywi się prądem 
elektrycznym. Chociaż ogólnie jest spokojny, 
może stać się agresywny, gdy jest przytłoczony mocą.',
'Raiju pobiera energię z pobliskich urządzeń elektrycznych, dzięki czemu porusza się szybciej.',
'Raiju nieustannie zakłóca działanie sprzętu elektronicznego ułatwiając śledzenie podczas ataku.',
'EMF poziom 5,Orb,Projektor D.O.T.S'
),
(
	'Obake',
	'Obake to przerażający zmniennokształtny,
mogący przybierać różne formy. Widziano,
jak przybierają humanoidalne kształty, aby
przyciągnąć swoją zdobycz.',
'Podczas interakcji z otoczeniem Obake rzadko pozostawia ślady.',
'Czasami ten duch zmienia kształt, pozostawiając po sobie unikalne dowody.',
'EMF poziom 5,Odciski palców,Orb'
),
(
	'Mimik',
	'Mimik jest nieuchwytnym tajemniczym
duchem naśladowcą, który imituje cechy i
zachowania innych, w tym inne typy duchów.',
'Nie jesteśmy pewni, do czego zdolny jest ten duch. Bądź ostrożny.',
'W kilku raportach odnotowano orby w pobliżu Mimika.',
'Spirit Box,Odciski palców,Mroźne temperatury'
),
(
	'Moroi',
	'Moroi powstał z grobu, aby wyssać energię z
żywych. Znany jest zt ego, że nakłada na
swoje ofiary klątwy, które można wyleczyć 
jedynie za pomocą antidotum lub uciekając 
bardzo daleko.',
'Im słabsze są jego ofiary, tym silniejszy Moro się staje.',
'Moroi cierpią na hiperosmnię, więc słabną na dłuższy czas.',
'Spirit Box,Pismo ducha,Mroźne temperatury'
),
(
	'Deogen',
	'Czasami otoczony nieskończoną mgłą. Deogen od lat 
wymyka się łowcom duchów.
Doniesiono, że te duchy potrafią znaleźć nawet 
najbardziej ukrytą zdobycz, po czym prześladuują ją 
aż do jej wycieńczenia.',
'Deogen nieustannie wyczuwa żywych. Możesz uciekać, ale nie możesz się ukryć.',
'Deogen wymaga dużo energii, aby się uformować i porusza siębardzo powoli będąc niedaleko ofiary.',
'Spirit Box,Pismo ducha,Projektor D.O.T.S'
),
(
	'Thaye',
	'Wiadomo, że Thaye szybko się starzeje,
nawet w życiu pozagrobowym, Z tego, czego
się dowiedzielismy, wydaje się, że ich stan
pogarsza się szybciej w obecności żywych.',
'Po wkroczeniu do lokacji, Thaye stanie się bardzo aktywny, defensywny i zwinny.',
'Thaye z czasem słabnie, co czyni go słabszy, wolniejszym i mniej agresywnym.',
'Orb,Pismo ducha,Projektor D.O.T.S'
);
end
	
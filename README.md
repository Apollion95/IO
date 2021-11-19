1. Wprowadzenie </br>
2.1. Opis Systemu</br>
Celem jest utworzenie aplikacji która pozwoli użytkownikom na korzystanie z wirtualnej księgarni. Aplikacja będzie pozwalała na tymczasowe wypożyczenie książki w wersji elektroniczej lub jej permanentny zakup i przypisanie do swojego konta. Za zakup, wypożyczenie oraz ocenę będa przewidziane punkty lojalnościowe. Dodatkowo będzie istniała możliwość wykupu subskrybcji podczas której użytkownik będzie miał darmowy dostęp do wielu tytułów. 

1.2. Słownik Pojęć</br>
-Użytkownik – osoba, która korzysta z programu/strony.</br>
-System – program, który ma za zadanie ułatwić pracę firmy.</br>
-Baza danych – program, który gromadzi dane i ułatwia dostęp do nich. Dzięki temu możliwa jest centralizacja danych.</br>
-Serwer (host) – główny komputer, na którym rezydują programy i który udostępnia komputerom-klientom swoją funkcjonalność poprzez przeglądarkę internetową.</br>
-Przeglądarka internetowa – program, który łączy się z serwerem, pobiera i wyświetla stronę internetową</br>
-klient – rozumiany w dwójnasób – jako osoba zlecająca firmie stworzenie projektu oraz jako komputer, który korzysta z usług innego komputera (serwera).</br>
-grupa – jest to pojęcie opisujące zbiór kliku osób</br>
-Architektura klient – serwer – forma komunikacji upraszczających model wzorcowy ISO OSI z siedmiu do 3 warstw: fizycznej, łącza danych oraz sesji realizowanej za pomocą protokołu zamówienie – odpowiedź. Centralizuje usługi, dzięki czemu firma korzysta zawsze z tej samej wersji oprogramowania. W naszym przypadku usługą tą jest udostępnianie stron html.</br>
-architektura – schemat ogólny budowy systemu komputerowego lub jego części, określający jego elementy, układy ich łączące i zasady współpracy między nimi.</br>
</br>
2.Model Procesów Biznesowych</br>
2.1 Obiekty Binesowe</br>
ID: 1</br>
Nazwa:	Księgarnia</br>
Opis:	Miejsce w ktróym użytkownik może przeglądać ofertę, przeczytać recenzje danej ksiażki, oraz kilka wybranych fragmentów.  Po zakupie książki w ksiegarni użytkownik może ją przeczytać w formie elektroniczej lub w bibliotece. </br>
ID: 2</br>
Nazwa:	Biblioteka</br>
Opis:	Miejsce w którym użytkownik ma dostęp do zakupionych przez siebie książęk.</br>
ID: 3</br>
Nazwa:	Forum</br>
Opis:	Podstrona księgarni która pozwala naszym zarejestrowanym użytkownikom na tworzenie wątków i prowadzenie dyskusji na temat książek, ich autorów. </br>
2.2 Aktorzy Biznesowi</br>
ID: 1</br>
Nazwa:	Użytkownik (Gość)</br>
Opis:	Użytkownik który nie zalogował się lub nieposiada swojego konta. Ma dostęp do najbardziej podstawowych funkcji. Na forum może nie mieć dostępu do niektórych funkcji i wątków. W Bibliotece może czytać tylko ogólnodostepne książki. </br>
ID: 2</br>
Nazwa:	Użytkownik Zalogowany</br>
Opis:	Użytkownik który posiada konto i jest do niego zalogowany. Może korzystać z forum, tworzyć nowe tematy, prowadzić dyskusje. Może również przeglądać swoje wypożyczone lub zakupione książki.</br>
dostęp do oferowanej treści.</br>
ID: 3</br>
Nazwa:	Subskrybent Premium</br>
Opis:	Użytkownik który wykupił subskrypcje i ma dostę do specjalnych treści przeznaczonych wyłącznie dla niego. Na forum posiada specjalny podpis który go wyróżnia. </br>
ID: 4</br>
Nazwa:	Administrator</br>
Opis:	Posiada pełen dostęp do serwisu. Służy jako pomoc techniczna dlaużytkowników.</br>
ID: 5</br>
Nazwa: Moderator</br>
Opis: Moderator zajmuje się forum, dba o przestrzeganie zasad i regulaminu. Blokuje lub wydaje ostrzeżenia do użytkowników forum którzy ich nie przestrzegają. </br>

3.Wymagania</br>
3.1 Wymagania Funkcjonalne</br>
ID:	1 </br>
Nazwa:	Tworzenie konta i logowanie</br>
Priorytet:	Najwyższy</br>
Rola:	Wszyscy</br>
Opis:	Utworzenie konta jednego z dostepem do Elektronicznej Księgarni oraz Forum. </br>
ID:	2</br>
Nazwa:	Zakup lub wypożyczenie książki</br>
Priorytet:	Najwyższy</br>
Rola:	Wszyscy</br>
Opis:	Możliwość wypożyczenia książki lub jej permanentnego wykupu i przypisania do swojego wczesniej utworzonego konta.</br>
ID:	3</br>
Nazwa:	System punktowy</br>
Priorytet:	Wysoki</br>
Rola:	Wszyscy</br>
Opis:	Za wypożyczanie oraz zakup przewidziane są punkty lojalnościowe. Punktów nie wolno wymienić, punkty decydują o randze użytkownika (przykład rangi: Początkujący, Średni Czytacz, Czytelnik, Stały Czytacz) która jest widoczna na forum. </br>
ID: 	4</br>
Nazwa: Nagrody</br>
Rola: Wszyscy</br>
Opis: Co piędziesiąt przeczytanych książek użytkownik może otrzymać darmowy i dożywotni dostęp do jeden z wybranych książek. Dostęp zostnaie przypisany do konta. </br>
ID:	5</br>
Nazwa:	Zakup subskrypcji Premium</br>
Priorytet:	Średni</br>
Rola:	Użytkownik</br>
Opis:	Zakup subskrybcji pozwoli na dostęp do wielu książek, podwojonej ilości punktów za wszystkie akcje. Dodatkowo użytkownik będzie się wyróżniał na forum. </br>
</br>
3.2 Wymagania Niefunkcjonalne</br>
ID:	1</br>
Nazwa:	Przejrzystość strony</br>
Priorytet:	Wysoki</br>
Opis:	Strona musi być przejrzysta, czytelna i łatwa w użyciu. Swoim wyglądem ma przyciągać użytkownika, a trescią i łatwoscią użytkowania, zatrzymać na dłużej. </br>
i przejrzysty.</br>

4.Technologia i Architketura</br>
4.1. Technologie</br>
-ASP.NET</br>

-React.JS</br>

-MySQL</br>

4.2. Opis Architektury</br>
-Do napisania interfejsu użytkownika zostanie wykorzystany React.JS.</br>

-Za mechanike systemu będzie odpowiadać ASP.NET.</br>

-Dane będą przechowywane w bazie opartej na MySQL.</br>
![image](https://user-images.githubusercontent.com/54260979/142664020-e094f156-357d-4a81-a958-3389dd7c21a1.png)


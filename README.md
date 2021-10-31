1. Wprowadzenie
1.1. Opis Systemu
Celem jest utworzenie aplikacji która pozwoli użytkownikom na korzystanie z wirtualnej księgarni. Aplikacja będzie pozwalała na tymczasowe wypożyczenie książki w wersji elektroniczej lub jej permanentny zakup i przypisanie do swojego konta. Za zakup, wypożyczenie oraz ocenę będa przewidziane punkty lojalnościowe. Dodatkowo będzie istniała możliwość wykupu subskrybcji podczas której użytkownik będzie miał darmowy dostęp do wielu tytułów. 

1.2. Słownik Pojęć
-Użytkownik – osoba, która korzysta z programu/strony.
-System – program, który ma za zadanie ułatwić pracę firmy.
-Baza danych – program, który gromadzi dane i ułatwia dostęp do nich. Dzięki temu możliwa jest centralizacja danych.
-Serwer (host) – główny komputer, na którym rezydują programy i który udostępnia komputerom-klientom swoją funkcjonalność poprzez przeglądarkę internetową.
-Przeglądarka internetowa – program, który łączy się z serwerem, pobiera i wyświetla stronę internetową
-klient – rozumiany w dwójnasób – jako osoba zlecająca firmie stworzenie projektu oraz jako komputer, który korzysta z usług innego komputera (serwera).
-grupa – jest to pojęcie opisujące zbiór kliku osób
-Architektura klient – serwer – forma komunikacji upraszczających model wzorcowy ISO OSI z siedmiu do 3 warstw: fizycznej, łącza danych oraz sesji realizowanej za pomocą protokołu zamówienie – odpowiedź. Centralizuje usługi, dzięki czemu firma korzysta zawsze z tej samej wersji oprogramowania. W naszym przypadku usługą tą jest udostępnianie stron html.
-architektura – schemat ogólny budowy systemu komputerowego lub jego części, określający jego elementy, układy ich łączące i zasady współpracy między nimi.

2.Model Procesów Biznesowych
2.1 Obiekty Binesowe
Nazwa:	Księgarnia
Opis:	Miejsce w ktróym użytkownik może przeglądać ofertę, przeczytać recenzje danej ksiażki, oraz kilka wybranych fragmentów.  Po zakupie książki w ksiegarni użytkownik może ją przeczytać w formie elektroniczej lub w bibliotece. 
Nazwa:	Biblioteka
Opis:	Miejsce w którym użytkownik ma dostęp do zakupionych przez siebie książęk.
Nazwa:	Forum
Opis:	Podstrona księgarni która pozwala naszym zarejestrowanym użytkownikom na tworzenie wątków i prowadzenie dyskusji na temat książek, ich autorów.
2.2 Aktorzy Biznesowi
Nazwa:	Użytkownik (Gość)
Opis:	Użytkownik który nie zalogował się lub nieposiada swojego konta. Ma dostęp do najbardziej podstawowych funkcji. Na forum może nie mieć dostępu do niektórych funkcji i wątków. W Bibliotece może czytać tylko ogólnodostepne książki. 
Nazwa:	Użytkownik Zalogowany
Opis:	Użytkownik który posiada konto i jest do niego zalogowany. Może korzystać z forum, tworzyć nowe tematy, prowadzić dyskusje. Może również przeglądać swoje wypożyczone lub zakupione książki.
dostęp do oferowanej treśći.
Nazwa:	Subskrybent Premium
Opis:	Użytkownik który wykupił subskrypcje i ma dostę do specjalnych treści przeznaczonych wyłącznie dla niego. Na forum posiada specjalny podpis który go wyróżnia. 
Nazwa:	Administrator
Opis:	Posiada pełen dostęp do serwisu. Służy jako pomoc techniczna dlaużytkowników.
Nazwa: Moderator
Opis: Moderator zajmuje się forum, dba o przestrzeganie zasad i regulaminu. Blokuje lub wydaje ostrzeżenia do użytkowników forum którzy ich nie przestrzegają. 
3.Wymagania
3.1 Wymagania Funkcjonalne
ID:	1
Nazwa:	Tworzenie konta i logowanie
Priorytet:	Najwyższy
Rola:	Wszyscy
Opis:	Utworzenie konta jednego z dostepem do Elektronicznej Księgarni oraz Forum. 

ID:	2
Nazwa:	Zakup lub wypożyczenie książki
Priorytet:	Najwyższy
Rola:	Wszyscy
Opis:	Możliwość wypożyczenia książki lub jej permanentnego wykupu i przypisania do swojego wczesniej utworzonego konta.

ID:	3
Nazwa:	System punktowy
Priorytet:	Wysoki
Rola:	Wszyscy
Opis:	Za wypożyczanie oraz zakup przewidziane są punkty lojalnościowe. Punktów nie wolno wymienić, punkty decydują o randze użytkownika (przykład rangi: Początkujący, Średni Czytacz, Czytelnik, Stały Czytacz) która jest widoczna na forum. 

ID: 	4
Nazwa: Nagrody
Rola: Wszyscy
Opis: Co piędziesiąt przeczytanych książek użytkownik może otrzymać darmowy i dożywotni dostęp do jeden z wybranych książek. Dostęp zostnaie przypisany do konta. 

ID:	5
Nazwa:	Zakup subskrypcji Premium
Priorytet:	Średni
Rola:	Użytkownik
Opis:	Zakup subskrybcji pozwoli na dostęp do wielu książek, podwojonej ilości punktów za wszystkie akcje. Dodatkowo użytkownik będzie się wyróżniał na forum. 

3.2 Wymagania Niefunkcjonalne
ID:	1
Nazwa:	Przejrzystość strony
Priorytet:	Wysoki
Opis:	Strona musi być przejrzysta, czytelna i łatwa w użyciu. Swoim wyglądem ma przyciągać użytkownika, a trescią i łatwoscią użytkowania, zatrzymać na dłużej. 
i przejrzysty.


4.Technologia i Architketura
4.1. Technologie
-ASP.NET

-React.JS

-MySQL

4.2. Opis Architektury
-Do napisania interfejsu użytkownika zostanie wykorzystany React.JS.

-Za mechanike systemu będzie odpowiadać ASP.NET.

-Dane będą przechowywane w bazie opartej na MySQL.


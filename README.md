# IOElektroniczna Księgarnia (EKA)
Dokument Specyfikacji Wymagań
dla <Podsystemu lub Funkcji>


Wersja <1.0>



 
Historia Zmian
Data	Wersja	Opis zmiany	Autor
27.10.2021	0.1	Pierwszy zarys dokumentu	Paweł Martosz
			
			
			

 
Spis treści
1.	Wprowadzenie	4
1.1	Opis systemu	4
1.2	Definicje, akronimy i skróty	4
2.	Opis ogólny	4
2.1	Diagram przypadków użycia	5
2.2	Scenariusze	6
2.3	Schemat bazy danych	6
3.	Technologia i Architektura	6
3.1	Technologie	6
 
Dokument Specyfikacji Wymagań 
1.	Wprowadzenie
1.1	Opis systemu
	System zostanie stworzony dla czytelników ebooków. System ma na celu umożliwić łatwy i szybki dostęp do wybranej przez użytkownika książki. Użytkownik może wykupić książkę z możliwością jej pobrania lub czasowy dostęp do książki.
1.2	Definicje, akronimy i skróty
	Użytkownik – osoba, która korzysta z programu/strony.
	System – program, który ma za zadanie ułatwić pracę firmy.
	Baza danych – program, który gromadzi dane i ułatwia dostęp do nich. Dzięki temu możliwa jest centralizacja danych.
	Serwer (host) – główny komputer, na którym rezydują programy i który udostępnia komputerom-klientom swoją funkcjonalność poprzez przeglądarkę internetową.
	Przeglądarka internetowa – program, który łączy się z serwerem, pobiera i wyświetla stronę internetową
	klient – rozumiany w dwójnasób – jako osoba zlecająca firmie stworzenie projektu oraz jako komputer, który korzysta z usług innego komputera (serwera).
	Architektura klient – serwer – forma komunikacji upraszczających model wzorcowy ISO OSI z siedmiu do 3 warstw: fizycznej, łącza danych oraz sesji realizowanej za pomocą protokołu zamówienie – odpowiedź.  Centralizuje usługi, dzięki czemu firma korzysta zawsze z tej samej wersji oprogramowania. W naszym przypadku usługą tą jest udostępnianie stron html.
	architektura – schemat ogólny budowy systemu komputerowego lub jego części, określający jego elementy, układy ich łączące i zasady współpracy między nimi.
2.	Opis ogólny
	System obejmuje gromadzenie danych w bazie oraz przydzielanie na podstawie określonych kryteriów tras kierowcom. System jest dostępny jedynie dla pracowników firmy. Produkt ma działać na serwerze, a dostęp do systemu posiada każda osoba która utworzyła konto w systemie. 
	Front-end zostanie napisany w React JS, Back-end w ASP.NET, a baza danych zostanie utworzona w MySQL, tak jak na schemacie poniżej. 
	 
2.1	Diagram przypadków użycia 

 
Aktor (Użytkownik) – jest obkietem zarejestrowanym w systemie 

Wypożyczenie książki - realizowana na czas okreśolny umożliwa dostęp do wybranej przez aktora książki w formie e booka. Aktor jednak musi kożystać z książki online.

Wykupienei nieograniczonedo dostępu pozwala aktorowi zakupić w formie e booka wybraną książkę oraz dostaję dostęp do pobrania.

Zwrucenie książki lub zamiana na inną – umożliwia zwróconej książki w formie e-book oraz pozwala na ponowy wybór innej książki. Jeśli była wypożyczona.





2.2	Scenariusze


 
2.3	Schemat bazy danych
 


3.	Technologia i Architektura
3.1	Technologie
1.1.	MySQL – przechowywanie danych 
1.2.	ASP. NET Web API  - backend 
1.3.	React JS - frontend

# Specyfikacja - Wirtualna Biblioteczka

### 1. Wprowadzenie

#### 1.1. Opis Systemu
Celem jest utworzenie utworzenie aplikacji, która umożliwi uzytkownikom korzystanie z książek(E-book). Aplikacja ma działać na zasadzie księgarni gdzie użytkownik może zakupić lub wypożyczyć swoją kopię produktu ale także składować swoje E-booki w formie biblioteczki. Po zakupie lub wypożyczeniu użytkownik ale także przeczytaniu zostanie nagrodzony odpowiednią ilość punktów które później będzie mógł wymienić na kody rabatowe(nie tylko obowiązujące w naszej aplikacji) lub nawet zakupić za te punkty kolejny produkt. Dla użykownika będzie również istniała możliwość wykupu subskrypcji w ramach której będzie otrzymywał co miesiąc darmowe kopie książek, po jej zakończeniu nadal będzie mógł z nich w pełni korzystać. Subksrypcja będzie obejmować grupy, każdy dodany do grupy będzie miał możliwość korzystania z biblioteki.

#### 1.2. Słownik Pojęć

-Użytkownik – osoba, która korzysta z programu/strony.

-System – program, który ma za zadanie ułatwić pracę firmy.

-Baza danych – program, który gromadzi dane i ułatwia dostęp do nich. Dzięki temu możliwa jest centralizacja danych.

-Serwer (host) – główny komputer, na którym rezydują programy i który udostępnia komputerom-klientom swoją funkcjonalność poprzez przeglądarkę internetową.

-Przeglądarka internetowa – program, który łączy się z serwerem, pobiera i wyświetla stronę internetową

-klient – rozumiany w dwójnasób – jako osoba zlecająca firmie stworzenie projektu oraz jako komputer, który korzysta z usług innego komputera (serwera).

-grupa – jest to pojęcie opisujące zbiór kliku osób

-Architektura klient – serwer – forma komunikacji upraszczających model wzorcowy ISO OSI z siedmiu do 3 warstw: fizycznej, łącza danych oraz sesji realizowanej za pomocą protokołu zamówienie – odpowiedź.  Centralizuje usługi, dzięki czemu firma korzysta zawsze z tej samej wersji oprogramowania. W naszym przypadku usługą tą jest udostępnianie stron html.

-architektura – schemat ogólny budowy systemu komputerowego lub jego części, określający jego elementy, układy ich łączące i zasady współpracy między nimi.

### 2.Model Procesów Biznesowych

### 3.Wymagania

#### 3.1 Wymagania Funkcjonalne

| ID:        | 1                                                                     |
|:-----------|:----------------------------------------------------------------------|
| Nazwa:     |Tworzenie konta                                                        |
| Priorytet: |Wysoki                                                                 |
| Rola:      |Wszyscy                                                                |
| Opis:      |Aplikcja oferuje tworzenie konta poprzez podane przez użytkownika <br> dane.|

| ID:        | 2                                                                                                           | 
|:-----------|:------------------------------------------------------------------------------------------------------------|
| Nazwa:     |Logowanie                                                                                                    |
| Priorytet: |Wysoki                                                                                                       |
| Rola:      |Wszyscy                                                                                                      |
| Opis:      |Za pomocą podanych przy logowaniu danych uwierzytelniającyh,<br> użytkownik uzyskuje dostęp do swojego konta.|

| ID:        | 3                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Zakup lub wypożyczenie książki                                              |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Wszyscy                                                                     |
| Opis:      |Aplikcja oferuje zakup lub wypożyczenie książek. Wypożyczenie będzie <br> ograniczone czasowo, natomiast zakup wiąże się z dożywotnim dostępem.|

| ID:        | 4                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Przechowywanie książek                                                      |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Wszyscy                                                                     |
| Opis:      |Użytkownik w każdym momencie będzie mógł uzyskać dostęp do produktów. <br> Będzie miał możliwość pobrania.|

| ID:        | 5                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Nagradzanie punkatami                                                       |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Wszyscy                                                                     |
| Opis:      |Aplikacja będzie nagradzać użytkownika punktami. Punkty będą przydzielane <br> za zakup, przeczytanie książki lub innego rodzaju aktywnośći <br> np. powiększenie swojej kolekcji.|

| ID:        | 6                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Wymiana punktów                                                             |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Użytkownik                                                                  |
| Opis:      |Możliwość wymiany puntków na nagraody, kody rabatowe lub nawet na darmowe <br> kopie książek|

| ID:        | 7                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Zakup subskrypcji                                                           |
| Priorytet: |Średni                                                                      |
| Rola:      |Użytkownik                                                                  |
| Opis:      |Subskrypcja zaoferuje użytkownikowi dostęp do określonej liczby książek za <br> darmo. Ich pula będzie się zmieniać co miesiąć. Będzie objęty <br> zniżkami na inne produkty oraz będzie miał dostęp przedpremierowo. <br> Będą istniały 2 rodzaje subskrypcji: Solo oraz Grupowa.|

| ID:        | 8                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Dodawanie użytkownika do grupy subskrypcji                                  |
| Priorytet: |Średni                                                                      |
| Rola:      |Użytkownik                                                                  |
| Opis:      |Po zakupie subksrypcji grupowej właściciel będzie mógł dodawać do grupy <br> innych użytkowników.|


#### 3.2 Wymagania Niefunkcjonalne

| ID:        | 1                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Podział odpowiedzalnośći                                                    |
| Priorytet: |Wysoki                                                                      |
| Opis:      |Platforma ma być podzielona na część frontendową jak i backendową. <br> Komunikacja pomiędzy tymi dwoma systemami powinna w głównej mierze odbywać <br> się przez endpointy API z autoryzacją opartą na JWT lub czymś podobnym.|

| ID:        | 2                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Łatwość w użyciu                                                            |
| Priorytet: |Wysoki                                                                      |
| Opis:      |Platforma ma być przyjazna dla użytkownika. Interfejs musi być nowoczesny <br> i przejrzysty.|

| ID:        | 3                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Intergralność danych                                                        |
| Priorytet: |Średni                                                                      |
| Opis:      |Zabezpieczenie przed nieautoryzowaną zmianą danych przez użycie szyfrowania <br> haseł oraz implementacja szyfrowanego połączenia https.|

| ID:        | 4                                                                          |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Przeładowanie Stron                                                         |
| Priorytet: |Średni                                                                      |
| Opis:      |Platforma powinna wczytywać się raz (brak przeładowywania podstron).        |


### 4.Technologia i Architketura

#### 4.1. Technologie
-ASP.NET(Backend)

-React.JS(Frontend)

-MySQL(Database)

#### 4.2. Opis Architektury

-Do napisania interfejsu użytkownika zostanie wykorzystany React.JS.

-Za mechanike systemu będzie odpowiadać ASP.NET.

-Dane będą przechowywane w bazie opartej na MySQL.

<img src="https://user-images.githubusercontent.com/56208135/139539073-5cf6cc5b-cd04-40c7-b59d-4254af0aeada.png">



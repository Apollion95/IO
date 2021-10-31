

# Specyfikacja - Wirtualna Biblioteczka

### 1. Wprowadzenie

#### 1.1. Opis Systemu
Celem jest utworzenie aplikacji, która umożliwi uzytkownikom korzystanie z książek(E-book). Aplikacja ma działać na zasadzie księgarni gdzie użytkownik może zakupić lub wypożyczyć swoją kopię produktu ale także składować swoje E-booki w formie biblioteczki. Po zakupie lub wypożyczeniu użytkownik ale także przeczytaniu zostanie nagrodzony odpowiednią ilość punktów które później będzie mógł wymienić na kody rabatowe(nie tylko obowiązujące w naszej aplikacji) lub nawet zakupić za te punkty kolejny produkt. Dla użykownika będzie również istniała możliwość wykupu subskrypcji w ramach której będzie otrzymywał co miesiąc darmowe kopie książek, po jej zakończeniu nadal będzie mógł z nich w pełni korzystać. Subksrypcja będzie obejmować grupy, każdy dodany do grupy będzie miał możliwość korzystania z biblioteki.

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

#### 2.1 Obiekty Binesowe

| Nazwa:| Księgarnia <img width=1000/>|         
|:------|:----------------------------------------------------------------------|
| Opis: |Miejsce w ktróym użytkownik może przeglądać dostępne E-booki, przeglądnąć kilka przykładowych stron, dokonwywać ich zakupu, czytać oraz wystawiać opinie.|

| Nazwa:| Biblioteka <img width=1000/>|
|:------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Opis: |Miejsce w którym użytkownik ma dostęp do zakupionych przez siebie książęk.|

| Nazwa:| Grupa <img width=1000/>                                               |
|:------|:----------------------------------------------------------------------|
| Opis: |Grupa posiada użytkowników oraz właściciela, który zarządza grupą i jej przywilejami. Grupy mają wspólną bibliotektę, które mogą zostać stworzone na początku tylko przez właściciela, który później przydzielając odpowiednie prawa może zezwolić na tę opcję innym użytkownikom.|

#### 2.2 Aktorzy Biznesowi


| Nazwa:| Użytkownik Niezalogowany <img width=1000/>                            |
|:------|:----------------------------------------------------------------------|
| Opis: |Użytkownik który nie zalogował sie lub nie wykreował swojego konta, ma <br> dostęp tylko do księgarni w której może przeglądać interesujące go książki.|

| Nazwa:| Użytkownik Zalogowany <img width=1000/>                                                  |
|:------|:----------------------------------------------------------------------|
| Opis: |Użytkownik który wykreował swoje konto ale także się zalogował ma pełny dostęp do oferowanej treśći.|

| Nazwa:| Subskrybent                 <img width=1000/>                                            |
|:------|:----------------------------------------------------------------------|
| Opis: |Użytkownik który wykupił subskrypcje i ma dostę do specjalnych treści przeznaczonych wyłącznie dla niego oraz użytkowników w jego grupie.|

| Nazwa:| Człownek Grupy       <img width=1000/>                                                   |
|:------|:----------------------------------------------------------------------|
| Opis: |Użytkownik dodany przez właściciela do grupy, ma dostę do treści sybskrybenta.|

| Nazwa:| Administrator          <img width=1000/>                                                 |
|:------|:----------------------------------------------------------------------|
| Opis: |Posiada pełen dostęp do serwisu. Służy jako pomoc techniczna dla użytkowników.|

### 3.Wymagania

#### 3.1 Wymagania Funkcjonalne

| ID:        | 1                   <img width=1000/>                                                    |
|:-----------|:----------------------------------------------------------------------|
| Nazwa:     |Tworzenie konta                                                        |
| Priorytet: |Wysoki                                                                 |
| Rola:      |Wszyscy                                                                |
| Opis:      |Aplikcja oferuje tworzenie konta poprzez podane przez użytkownika dane.|

| ID:        | 2                   <img width=1000/>                                                                                          | 
|:-----------|:------------------------------------------------------------------------------------------------------------|
| Nazwa:     |Logowanie                                                                                                    |
| Priorytet: |Wysoki                                                                                                       |
| Rola:      |Wszyscy                                                                                                      |
| Opis:      |Za pomocą podanych przy logowaniu danych uwierzytelniającyh, użytkownik uzyskuje dostęp do swojego konta.|

| ID:        | 3                    <img width=1000/>                                                        |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Zakup lub wypożyczenie książki                                              |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Wszyscy                                                                     |
| Opis:      |Aplikcja oferuje zakup lub wypożyczenie książek. Wypożyczenie będzie  ograniczone czasowo, natomiast zakup wiąże się z dożywotnim dostępem.|

| ID:        | 4                   <img width=1000/>                                                         |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Przechowywanie książek                                                      |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Wszyscy                                                                     |
| Opis:      |Użytkownik w każdym momencie będzie mógł uzyskać dostęp do produktów. <br> Będzie miał możliwość pobrania.|

| ID:        | 5                    <img width=1000/>                                                        |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Nagradzanie punkatami                                                       |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Wszyscy                                                                     |
| Opis:      |Aplikacja będzie nagradzać użytkownika punktami. Punkty będą przydzielane za zakup, przeczytanie książki lub innego rodzaju aktywnośći <br> np. powiększenie swojej kolekcji.|

| ID:        | 6                      <img width=1000/>                                                      |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Wymiana punktów                                                             |
| Priorytet: |Wysoki                                                                      |
| Rola:      |Użytkownik                                                                  |
| Opis:      |Możliwość wymiany puntków na nagraody, kody rabatowe lub nawet na darmowe <br> kopie książek|

| ID:        | 7                     <img width=1000/>                                                       |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Zakup subskrypcji                                                           |
| Priorytet: |Średni                                                                      |
| Rola:      |Użytkownik                                                                  |
| Opis:      |Subskrypcja zaoferuje użytkownikowi dostęp do określonej liczby książek za darmo. Ich pula będzie się zmieniać co miesiąć. Będzie objęty zniżkami na inne produkty oraz będzie miał dostęp przedpremierowo.  Będą istniały 2 rodzaje subskrypcji: Solo oraz Grupowa.|

| ID:        | 8                      <img width=1000/>                                                      |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Dodawanie użytkownika do grupy subskrypcji                                  |
| Priorytet: |Średni                                                                      |
| Rola:      |Użytkownik                                                                  |
| Opis:      |Po zakupie subksrypcji grupowej właściciel będzie mógł dodawać do grupy  innych użytkowników.|


#### 3.2 Wymagania Niefunkcjonalne

| ID:        | 1                       <img width=1000/>                                                     |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Podział odpowiedzalnośći                                                    |
| Priorytet: |Wysoki                                                                      |
| Opis:      |Platforma ma być podzielona na część frontendową jak i backendową. Komunikacja pomiędzy tymi dwoma systemami powinna w głównej mierze odbywać się przez endpointy API z autoryzacją opartą na JWT lub czymś podobnym.|

| ID:        | 2                       <img width=1000/>                                                     |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Łatwość w użyciu                                                            |
| Priorytet: |Wysoki                                                                      |
| Opis:      |Platforma ma być przyjazna dla użytkownika. Interfejs musi być nowoczesny i przejrzysty.|

| ID:        | 3                      <img width=1000/>                                                      |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Intergralność danych                                                        |
| Priorytet: |Średni                                                                      |
| Opis:      |Zabezpieczenie przed nieautoryzowaną zmianą danych przez użycie szyfrowania haseł oraz implementacja szyfrowanego połączenia https.|

| ID:        | 4                       <img width=1000/>                                                     |
|:-----------|:---------------------------------------------------------------------------|
| Nazwa:     |Przeładowanie Stron                                                         |
| Priorytet: |Średni                                                                      |
| Opis:      |Platforma powinna wczytywać się raz (brak przeładowywania podstron).        |


### 4.Technologia i Architektura

#### 4.1. Technologie
-ASP.NET

-React.JS

-MySQL

#### 4.2. Opis Architektury

-Za frontend będzie odpowiadać Reacj.JS w którym zostanie napisany interfejs użytkownika z którym to będzie mógł wchodzić w interakcję.

-Za backend odpowiada ASP.NET w którym zostanie napisany Web API. W ASP.NET zostanie wykonana mechanika strony oraz połączenie z bazą danych. 

-Za przechowywanie danych będzie odpowiadać baza danych MySQL. Będą się w niej znajodwać informacje o klientach, subksrybentach oraz książkach.

![image](https://user-images.githubusercontent.com/56208135/139593932-508362fd-074d-4bef-b898-e03149c3f736.png)



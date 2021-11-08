# Księgarnia Online
###### Wersja: 1.0.0v


## Spis treści

1. Wprowadzenie

   * Cel dokumnetu 
   * Zakres dokumentu
   * Definicje, akronimy oraz skróty użyte w dokumencie 
   
   
2. Opis

   * Cel ssytemu
   * Funkcje systemu
   * Klasy i cechy użytkowników
   * Opis technologii oraz architektury
   
   
3. Funkcje systemu(przypadki użycia)

   * Rejestracja użytkownika 
   * Logowanie
   * Wylogowanie
   * Edycja danych
   * Wyszukiwanie ebooków
   * Dodawanie środków
   * Dodawanie ebooków do koszyka
   * Usuwanie ebooków z koszyka
   * Kupowanie ebooków
   * Wyświetlenie historii wydanych środków
   * Kontakt z administratorem 
   * Zbieranie punktów
   * Wydawanie punktów
   * Dodawanie ebooków do systemu
   * Modyfikowanie ebooków z systemu
   * Usuwanie ebooków z systemu
   * Przeglądanie ebooków
   * Przeglądanie użytkowników
   * Usuwanie użytkowników
   * Przyjmowanie zgłoszeń 




## 1. Wprowadzenie 
----------------------

### 1.1 Cel dokumentu


  Celem niniejszego dokumentu jest przedstawienie specyfikacji wymagań oraz wyników fazy analizy na potrzeby projektu Księgarnia Online. Dokument ten służy do przedstawienia poszczególnych celów oraz proponowanych planów rozwoju systemu.
  

### 1.2 Zakresu dokumentu

Dokument ten przedstawia plany, założenia oraz cele które powinien zrealizować system przedstawione przez klienta w odpowiedniej, zwięzłej oraz przystępnej formie.


### 1.3 Definicje, akronimy oraz skróty używane w dokumencie 

* **Użytkownik** – osoba z dostępem do internetu, korzystająca z systemu Księgarnia Online i posiadająca konto w systemie
* **Administrator** – osoba z wyższymi uprawnieniami oddelegowana do zarządzania systemem
* **System/Platforma/Aplikacja** – skrótowa forma reprezentująca Księgarnię Online.
* **Baza danych** – program służący do gromadzenia i przechowywania danych w aplikacji
* **API** – metoda odpowiedzialna za komunikację pomiędzy poszczególnymi składowymi aplikacji( Udostępniana przez .NET Core)
* **Frontend** – część systemu odpowiedzialna za interakcję z użytkownikiem/administratorem
* **Backend** – część systemu odpowiedzialna za logikę kryjącą się za aplikacją




## 2. Opis
----------

### 2.1 Cel systemu Księgarnia Online

Celem systemu jest stworzenie platformy udostępniającej książki w postaci ebooków dla użytkowników. Ma to na celu umożliwienie kupowania książek na stronie tym samym pozwalając na czytanie bez konieczności udania się do księgarni. Strona jest dostępna dla każdego zarejestrowanego użytkownika z dostępem do internetu oraz dowolnej przeglądarki zaktualizowanej do najwyższej możliwej wersji. System za pomocą interfejsu umożliwi klientom szereg funkcji związanych z działalnością księgarni, takich jak utworzenie konta, przeglądanie, wyszukiwanie, kupowanie, czytanie wybranych pozycji. Klient za kupowanie książek otrzymuje punkty które może później  wymienić na uzyskanie rabatu dla wybranej przez siebie pozycji lub otrzymać darmową książkę z dostępnej puli książek. 


### 2.2 Funkcje systemu

* Rejestracja nowego użytkownika
* Logowanie do platformy
* Wylogowanie z platformy
* Edycja danych użytkownika/uwierzytelniających 
* Wyszukiwanie ebooków
* Dodanie środków do e-portfela
* Dodanie ebooków do koszyka
* Usuwanie ebooków z koszyka
* Kupowanie ebooków
* Wyświetlenie historii wydanych środków
* Kontakt z administratorem 
* Zbieranie punktów
* Wydawanie punktów
* Dodawanie ebooków do systemu
* Modyfikowanie ebooków z systemu
* Usuwanie ebooków z systemu
* Przeglądanie ebooków 
* Przeglądanie użytkowników
* Usuwanie użytkownika
* Przyjmowanie zgłoszeń od użytkownika


### 2.3 Klasy i cechy użytkowników

W systemie istnieją dwa rodzaje użytkowników: Administrator oraz Użytkownik. Poniższa tabela przedstawia funkcjonalności poszczególnych ról.


|Funkcjonalność | Użytkownik | Administrator|
|:-------------:|:----------:|:------------:|
|Rejestracja użytkownika | + | - |
|Logowanie do platformy | + | + |
|Wylogowanie z platformy | + | + |
|Edycja danych użytkownika/uwierzytelniających | + | + |
|Wyszukiwanie ebooków | + | + |
|Dodanie środków do e-portfela | + | - | 
|Dodanie ebooków do koszyka | + | - |
|Usuwanie ebooków z koszyka | + | - |
|Kupowanie ebooków | + | - | 
|Wyświetlenie historii wydanych środków | + | - |
|Kontakt z administratorem | + | + |
|Zbieranie punktów | + | - |
|Wydawanie punktów | + | - |
|Dodawanie ebooków do systemu | - | + | 
|Modyfikowanie ebooków z systemu | - | + |
|Usuwanie ebooków z sytemu | - | + |
|Przeglądanie ebooków | + | + |
|Przeglądanie użytkowników | - | + | 
|Usuwanie użytkownika | - | + |
|Przyjmowanie zgłoszeń | - | + |
  
### 2.4 Opis technologii oraz architektury

System będzie działał na trzech platformach

* Dane użytkowników związane z ich kontem, dane poszczególnych ebooków oraz pozostałe dane związane z działaniem platformy będą zapisywane w bazie danych: **MySQL**
* Za zarządzanie całym systemem(backend) odpowiedzialna będzie aplikacja **.Net Core** udostępniająca odpowiednie API.
* Na frontendzie będzie wykorzystany framework **React JS** odpowiedzialny za odpowiedni wygląd platformy oraz stanowiący interfejs do komunikacji użytkownika z aplikacją.

## 3 Funkcje systemu(przypadki użycia)

-- ss1

### 3.1 Rejestracja użytkownika

* **Cel:**
  Celem tej funkcjonalności jest stworzenie konta dla nowego użytkownika w celu możliwości zalogowania się do systemu.
* **Wejście:** 
  Osoba wprowadza e-mail, hasło oraz dane demograficzne.
* **Wyjście:** 
  Osoba otrzymuje informację o poprawnym założeniu konta lub o  błędzie.
* **Główny scenariusz:**
  Osoba chce skorzystać z systemu oraz jego funkcji, aby tego dokonać musi posiadać konto w systemie.
* **Kroki:**
  * Krok 1: Osobie korzystającej wyświetla się ekran z możliwością zarejestrowania lub zalogowania.
  * Krok 2: Osoba wybiera opcję rejestracji.
  * Krok 3: Osoba wypełnia wymagane dane w formularzu.
  * Krok 4: Osoba otrzymuje informację o pomyślnym utworzeniu konta lub o wystąpieniu błędu.
* **Przykład:**

-- ss2

### 3.2 Logowanie

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie użytkownikowi/administratorowi  uzyskania dostępu do systemu.
* **Wejście:** 
  Użytkownik/Administrator wprowadza e-mail, hasło.
* **Wyjście:** 
  Użytkownik/Administrator otrzymuje informację o poprawnym zalogowaniu lub niepoprawnych danych.
* **Główny scenariusz:**
  Użytkownik/Administrator chce uzyskać dostęp do swojego konta oraz systemu i jego funkcji, w tym celu musi się zalogować korzystając ze swojego konta.
* **Kroki:**
  * Krok 1: Użytkownikowi/Administratorowi wyświetla się ekran z możliwością zarejestrowania lub zalogowania.
  * Krok 2: Użytkownik/Administrator wybiera opcję logowania.
  * Krok 3: Użytkownik/Administrator wypełnia wymagane dane w formularzu.
  * Krok 4: Użytkownik/Administrator otrzymuje informację o pomyślnym zalogowaniu lub o błędnych danych.
* **Przykład:**

-- ss3


### 3.3 Wylogowanie

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie użytkownikowi/administratorowi  wylogowanie się z systemu tym samym zakończenie sesji korzystania z sytemu.
* **Wejście:** 
  Użytkownik/Administrator klika przycisk „Wyloguj”.
* **Wyjście:** 
  Użytkownik/Administrator otrzymuje informację o poprawnym wylogowaniu oraz zostaje przeniesiony na stronę główna.
* **Główny scenariusz:**
 Użytkownik/Administrator chce zakończyć korzystanie z systemu tym samym zabezpieczyć swoje konto przed nieautoryzowanym dostępem.
* **Kroki:**
  * Krok 1: Krok 1: Użytkownik/Administrator klika przycisk wyloguj.
* **Przykład:**

-- ss4

### 3.4 Edycja danych

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie Użytkownikowi/Administratorowi edycję danych.
* **Wejście:** 
  Użytkownik/Administrator klika przycisk „Edytuj dane”. Użytkownik/Administrator edytuje wybrane dane. 
* **Wyjście:** 
  Komunikat o poprawnym zapisaniu nowych danych lub komunikat o błędzie.
* **Główny scenariusz:**
 Użytkownik/Administrator chce zaktualizować/edytować dane dotyczące swojego konta, w celu bezpieczeństwa/spójności lub poprawności danych.
* **Kroki:**
  * Krok 1: Użytkownik/Administrator przechodzi do zakładki „Ustawienia konta”.
  * Krok 2: Użytkownik/Administrator klika przycisk „Edytuj dane”
  * Krok 3: Użytkownik/Administrator wypełnia poszczególne dane.
  * Krok 4: Użytkownik/Administrator klika przycisk „Zapisz”.
* **Przykład:**

-- ss5

### 3.5 Wyszukiwanie ebooków

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie Użytkownikowi/Administratorowi znalezienie wybranej pozycji w systemie lub określonej grupy na podstawie nazwy oraz filtrów.
* **Wejście:** 
  Użytkownik/Administrator wypełnia pole określające czego szuka (autor, tytuł, numer ISBN).
  
  Użytkownik/Administrator opcjonalnie określa filtry na podstawie których chce przeszukać księgarnie.
  
  Użytkownik/Administrator klika przycisk „Szukaj”.
* **Wyjście:** 
 Wyświetlenie danej pozycji, kolekcji lub otrzymanie komunikatu o braku.
* **Główny scenariusz:**
 Użytkownik/Administrator chce przeszukać księgarnie aby  znaleźć odpowiednią pozycję lub kolekcję w celu dalszej interakcji .
* **Kroki:**
  * Krok 1: Użytkownik/Administrator wypełnia główne pole wpisując odpowiednią frazę.
  * Krok 2: Użytkownik/Administrator opcjonalnie wybiera filtry w celu zawężenia możliwych opcji”.
  * Krok 3: Użytkownik/Administrator klika przycisk „Szukaj”.
* **Przykład:**

-- ss6

### 3.6 Dodanie środków do e-portfela

* **Cel:**
 Celem tej funkcjonalności jest umożliwienie Użytkownikowi dodania środków do portfela w celu wykorzystania ich na usługi dostępne w systemie
* **Wejście:** 
  Użytkownik wybiera formę doładowania.Użytkownik określa kwotę doładowania.
  
  Użytkownik/Administrator klika przycisk „Szukaj”.
* **Wyjście:** 
  Wyświetlenie komunikatu o dodaniu środków lub o błędzie.
* **Główny scenariusz:**
 Użytkownik chce skorzystać z funkcji płatnych jakie oferuje system, tym samym doładowuje środki do swojego portfela za pomocą odpowiedniej kwoty oraz formy doładowania.
* **Kroki:**
  * Krok 1: Użytkownik wchodzi w zakładkę e-portfel.
  * Krok 2: Użytkownik wybiera opcję doładowania.
  * Krok 3: Użytkownik wybiera formę doładowania.
  * Krok 4: Użytkownik określa kwotę doładowania.
  * Krok 5:  Użytkownik potwierdza transakcję.
* **Przykład:**

-- ss7


### 3.7 Dodanie ebooków do koszyka

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie Użytkownikowi dodania wielu pozycji do koszyka w celu wykonania jednego zamówienia wraz z wszystkimi wybranymi pozycjami zamiast wykonywania pojedynczych transakcji.
* **Wejście:** 
  Użytkownik dodaje poszczególne pozycje do koszyka.
* **Wyjście:** 
  Wyświetlenie komunikatu o dodaniu pozycji do koszyka.
* **Główny scenariusz:**
  Użytkownik chce wykonać większe zamówienie, tym samym przeszukuje księgarnie w celu znalezienia interesujących go pozycji. Po znalezieniu danej pozycji Użytkownik klika    przycisk „Dodaj do koszyka”.
* **Kroki:**
  * Krok 1: Użytkownik wyszukuje dane pozycje.
  * Krok 2: Użytkownik dodaje znalezioną pozycję do koszyka za pomocą przycisku.
* **Przykład:**

-- ss8

### 3.8 Usuwanie ebooków z koszyka

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie usunięcia poszczególnych pozycji z zamówienia.
* **Wejście:** 
  Użytkownik klika przycisk „Usuń”.
* **Wyjście:** 
  Wyświetlenie komunikatu o usunięciu pozycji z koszyka.
* **Główny scenariusz:**
   Użytkownik chce usunąć daną pozycję z zamówienia, w tym celu wchodzi w zakładkę koszyk reprezentującą zamówienie. Następnie klika przycisk „Usuń” przy wybranej pozycji.
* **Kroki:**
  * Krok 1: Użytkownik otwiera zakładkę „Koszyk”.
  * Krok 2: Użytkownik klika przycisk „Usuń” przy wybranej pozycji.
* **Przykład:**

-- ss9


### 3.9 Kupowanie ebooków

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie Użytkownikowi złożenie oraz opłacenie zamówienia.
* **Wejście:** 
  Użytkownik klika przycisk „Złóż zamówienie”.
  
  Użytkownik sprawdza formularz zamówienia.
  
  Użytkownik potwierdza zamówienie.
* **Wyjście:** 
  Wyświetlenie komunikatu o przyjęciu zamówienia lub o błędzie.
  
  W przypadku powodzenia pobierana jest opłata oraz udostępniana dana pozycja/pozycje.
* **Główny scenariusz:**
   Użytkownik chce sfinalizować zamówienie w tym  celu wchodzi w zakładkę „Koszyk” klika przycisk „Złóż zamówienie”. Następnie sprawdza formularz po czym zatwierdza zamówienie poprzez przycisk „Zatwierdź”.
* **Kroki:**
  * Krok 1: Użytkownik otwiera zakładkę „Koszyk”.
  * Krok 2: Użytkownik klika przycisk „Złóż zamówienie”.
  * Krok 3: Użytkownik sprawdza poprawność danych pozycji w formularzu.
  * Krok 4: Użytkownik potwierdza zamówienie.
* **Przykład:**

-- ss10


### 3.10 Wyświetlenie historii wydanych środków

* **Cel:**
  Celem tej funkcjonalności jest umożliwienie Użytkownikowi otrzymanie informacji na temat złożonych zamówień.
* **Wejście:** 
  Użytkownik wybiera zakładkę „Historia”.
* **Wyjście:** 
 Wyświetlenie historii zamówień.
* **Główny scenariusz:**
  Użytkownik chce sprawdzić złożone przez siebie zamówienia, przechodzi w zakładkę odpowiedzialną za historię, otrzymuje zestawienie wykonanych zamówień. poprzez przycisk „Zatwierdź”.
* **Kroki:**
  * Krok 1: Użytkownik otwiera zakładkę „Historia”.
  * Krok 2: Użytkownik opcjonalnie wybiera określone filtry(łączna cena / data złożenia ... )
  * Krok 3: Użytkownik klika „Szukaj”.
* **Przykład:**

-- ss11

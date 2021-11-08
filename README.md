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
  Krok 1: Osobie korzystającej wyświetla się ekran z możliwością zarejestrowania lub zalogowania.
  Krok 2: Osoba wybiera opcję rejestracji.
  Krok 3: Osoba wypełnia wymagane dane w formularzu.
  Krok 4: Osoba otrzymuje informację o pomyślnym utworzeniu konta lub o wystąpieniu błędu.
* **Przykład:**

-- ss2

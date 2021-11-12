## **Funkcje systemu** (przypadki użycia)

----przypadki.png------

- - - 

### Rejestracja użytkownika

* **Cel**: 
        Celem tej funkcjonalności jest stworzenie konta dla nowego użytkownika w celu możliwości zalogowania się do systemu.
        
* **Wejście**:
        Osoba wprowadza e-mail, hasło oraz dane demograficzne.
        
* **Wyjście**:
        Osoba otrzymuje informację o poprawnym założeniu konta lub o  błędzie.
        
* **Główny scenariusz**:
        Osoba chce skorzystać z systemu oraz jego funkcji, aby tego dokonać musi posiadać konto w systemie.
        
* **Kroki**:

        - Krok 1: Osobie korzystającej wyświetla się ekran z możliwością zarejestrowania lub zalogowania.
        
        - Krok 2: Osoba wybiera opcję rejestracji.
        
        - Krok 3: Osoba wypełnia wymagane dane w formularzu.
        
        - Krok 4: Osoba otrzymuje informację o pomyślnym utworzeniu konta lub o wystąpieniu błędu.
        

* **Przykład**:

----rejestracja.png------

- - - 

### Logowanie

* **Cel**: 
       Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium/administratorowi  uzyskania dostępu do systemu.
        
* **Wejście**:
        Użytkownik/Użytkownik premium/Administrator wprowadza dane logowania.
        
* **Wyjście**:
       Użytkownik/Użytkownik premium/Administrator otrzymuje informację o poprawnym zalogowaniu oraz dostęp do systemu lub komunikat o wprowadzeniu nieodpowiednich danych.
        
* **Główny scenariusz**:
       Użytkownik/Użytkownik premium/Administrator chce uzyskać dostęp do swojego konta oraz systemu i jego funkcji, w tym celu musi się zalogować korzystając ze swojego konta.
        
* **Kroki**:

        - Krok 1: Użytkownikowi/Użytkownikowi premium/Administratorowi wyświetla się ekran z możliwością zarejestrowania lub zalogowania.

        - Krok 2: Użytkownik/Użytkownik premium/Administrator wybiera opcję logowania.

        - Krok 3: Użytkownik/Użytkownik premium/Administrator wypełnia wymagane dane w formularzu.

        - Krok 4: Użytkownik/Użytkownik premium/Administrator otrzymuje informację o pomyślnym zalogowaniu lub o błędnych danych.

        

* **Przykład**:

----logowanie.png------

- - - 

### Wylogowanie

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/administratorowi  wylogowanie się z systemu tym samym zakończenie sesji korzystania z sytemu.
     
* **Wejście**:
        Użytkownik/Użytkownik premium/Administrator  klika przycisk „Wyloguj”.
        
* **Wyjście**:
       Użytkownik/Użytkownik premium/Administrator otrzymuje informację o poprawnym wylogowaniu oraz zostaje przeniesiony na stronę główna.
        
* **Główny scenariusz**:
       Użytkownik/Użytkownik premium/Administrator chce zakończyć korzystanie z systemu tym samym zabezpieczyć swoje konto przed nieautoryzowanym dostępem.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium/Administrator klika przycisk wyloguj.

        - Krok 2: Zamykana jest sesja określonego użytkownika/użytkownika premium/administratora.
       

* **Przykład**:

----wylogowanie.png------

- - -

### Edycja danych profilu

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium/administratorowi edycję danych przypisanych do konta.
     
* **Wejście**:
        Użytkownik/Użytkownik premium/Administrator edytuje wybrane dane. 
        
* **Wyjście**:
       Komunikat o poprawnym zapisaniu nowych danych lub komunikat o błędzie.
        
* **Główny scenariusz**:
       Użytkownik/Użytkownik premium/Administrator chce zaktualizować/edytować dane dotyczące swojego konta, w celu bezpieczeństwa/spójności lub poprawności danych.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium/Administrator przechodzi do zakładki „Ustawienia konta”.
        
        - Krok 2: Użytkownik/Użytkownik premium/Administrator klika przycisk „Edytuj dane”.
        
        - Krok 3: Użytkownik/Użytkownik premium/Administrator wypełnia poszczególne dane.
        
        - Krok 4: Użytkownik/Użytkownik premium/Administrator klika przycisk „Zapisz”.

       

* **Przykład**:

----edycja_danych.png------

- - -



### Wyszukiwanie pozycji

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie Użytkownikowi/Administratorowi znalezienie wybranej pozycji w systemie lub określonej grupy na podstawie frazy oraz filtrów.
     
* **Wejście**:
        Użytkownik/Użytkownik premium/Administrator wprowadza frazę do wyszukania (autor / tytuł / ISBN).
        
* **Wyjście**:
       Wyświetlenie danej pozycji, kolekcji lub otrzymanie komunikatu o braku.
        
* **Główny scenariusz**:
       Użytkownik/Użytkownik premium/Administrator chce przeszukać księgarnie aby  znaleźć odpowiednią pozycję lub grupę pozycji w celu dalszej interakcji .
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium/Administrator wypełnia główne pole wpisując odpowiednią frazę.
        
        - Krok 2: **(Opcjonalnie)** Użytkownik/Użytkownik premium/Administrator zawęża wyniki przy pomocy filtrów.
        
        - Krok 3: Użytkownik/Użytkownik premium/Administrator klika przycisk „Szukaj”.

       

* **Przykład**:

----wyszukiwanie_pozycji.png------

- - -

### Dodanie środków do e-portfela 

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi / użytkownikowi premium dodanie środków do portfela w celu wykorzystania ich na usługi dostępne w systemie.
     
* **Wejście**:
        Użytkownik/Użytkownik premium wybiera opcję doładowania konta.
        
* **Wyjście**:
       Wyświetlenie komunikatu o dodaniu środków lub o wystąpieniu błędu.
        
* **Główny scenariusz**:
       Użytkownik/Użytkownik premium chce skorzystać z funkcji płatnych jakie oferuje system, tym samym doładowuje środki do swojego portfela za pomocą odpowiedniej kwoty oraz          formy doładowania.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik wchodzi w zakładkę e-portfel.
        
        - Krok 2: Użytkownik/Użytkownik wybiera opcję doładowania.
        
        - Krok 3: Użytkownik/Użytkownik wybiera formę doładowania.
        
        - Krok 4: Użytkownik/Użytkownik określa kwotę doładowania.
        
        - Krok 5: Użytkownik/Użytkownik potwierdza transakcję.

       

* **Przykład**:

----dodanie_środków.png------

- - -


### Dodanie pozycji do koszyka

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium dodania wielu pozycji do koszyka w celu wykonania jednego zamówienia wraz z wszystkimi wybranymi pozycjami zamiast wykonywania pojedynczych transakcji.
     
* **Wejście**:
        Użytkownik/Użytkownik premium dodaje pozycje do koszyka.
        
* **Wyjście**:
       Wyświetlenie komunikatu o dodaniu pozycji do koszyka.
        
* **Główny scenariusz**:
      Użytkownik/Użytkownik premium chce wykonać większe zamówienie, tym samym przeszukuje księgarnie w celu znalezienia interesujących go pozycji. Po znalezieniu danej pozycji  klika przycisk „Dodaj do koszyka”.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium wyszukuje określoną pozycję.

        - Krok 2: Użytkownik/Użytkownik premium dodaje znalezioną pozycję do koszyka za pomocą przycisku.

       

* **Przykład**:

----dodanie_pozycji_do_koszyka.png------

- - -

### Usuwanie pozycji z koszyka

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie usunięcia poszczególnych pozycji z koszyka.
     
* **Wejście**:
        Użytkownik/Użytkownik premium klika przycisk „Usuń”.
        
* **Wyjście**:
       Wyświetlenie komunikatu o usunięciu pozycji z koszyka.
        
* **Główny scenariusz**:
      Użytkownik/Użytkownik premium chce usunąć daną pozycję z koszyka, w tym celu wchodzi w zakładkę koszyk reprezentującą zamówienie. Następnie klika przycisk „Usuń” przy wybranej pozycji.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik otwiera zakładkę „Koszyk”.
        
        - Krok 2: Użytkownik/Użytkownik przycisk „Usuń” przy wybranej pozycji.

       

* **Przykład**:

----usunięcie_pozycji_z_koszyka.png------

- - -


### Złożenie zamówienia 

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie uzytkownikowi/użytkownikowi premium złożenie oraz opłacenie zamówienia.
     
* **Wejście**:
        Użytkownikowi/Użytkownikowi premium potiwerdza zamówienie
        
* **Wyjście**:
      - Wyświetlenie komunikatu o przyjęciu zamówienia lub o błędzie.     
      - W przypadku powodzenia pobierana jest opłata oraz udostępniane są pozycje z zamówienia.

        
* **Główny scenariusz**:
      Użytkownik/Użytkownik premium chce sfinalizować zamówienie w tym  celu wchodzi w zakładkę „Koszyk” klika przycisk „Złóż zamówienie”. Następnie sprawdza formularz po czym zatwierdza zamówienie poprzez przycisk „Zatwierdź”.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium otwiera zakładkę "Koszyk"
        
        - Krok 2: Użytkownik/Użytkownik premium klika przycisk „Złóż zamówienie”.
        
        - Krok 3: Użytkownik/Użytkownik premium sprawdza poprawność danych pozycji w formularzu.
        
        - Krok 4: Użytkownik/Użytkownik premium potwierdza zamówienie.

       

* **Przykład**:

----złóż_zamówienie.png------

- - -

### Historia zamówień

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium otrzymanie informacji na temat złożonych zamówień.
     
* **Wejście**:
        Użytkownik/Użytkownik premium wybiera zakładkę „Historia”.
        
* **Wyjście**:
        Wyświetlenie historii zamówień.
        
* **Główny scenariusz**:
      Użytkownik/Użytkownik premium chce sprawdzić złożone przez siebie zamówienia, przechodzi w zakładkę odpowiedzialną za historię, otrzymuje zestawienie wykonanych zamówień.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium otwiera zakładkę „Historia”.
        
        - Krok 2: Użytkownik/Użytkownik premium opcjonalnie wybiera określone filtry(łączna cena / data złożenia … )
        
        - Krok 3: Użytkownik/Użytkownik premium klika „Szukaj”.

       

* **Przykład**:

----historia.png------

- - -

### Kontakt z administracją

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium skontaktowanie się z administratorem systemu poprzez wysłanie zgłoszenia.
     
* **Wejście**:
        Użytkownik/Użytkownik premium wysyła zgłoszenie
        
* **Wyjście**:
        Potwierdzenie wysłania zgłoszenia.
        
* **Główny scenariusz**:
         Użytkownik/Użytkownik premium chce skontaktować się z administracją serwisu np. w celu złożenia zapytania/prośby o usunięcie konta. 
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium otwiera zakładkę „Kontakt”.
        
        - Krok 2: Użytkownik/Użytkownik premium klika przycisk „Wyślij zgłoszenie”.
        
        - Krok 3: Użytkownik/Użytkownik premium wypełnia formularz zgłoszeniowy.
        
        - Krok 4: Użytkownik/Użytkownik premium klika przycisk „Wyślij”.

       

* **Przykład**:

----kontakt.png------

- - -

### Zdobywanie punktów

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie zbierania punktów użytkownikowi/użytkownikowi premium za wydawanie dostępnych środków oraz za wykonywanie określonych aplikacji w systemie.
     
* **Wejście**:
        Użytkowik/Użytkownik premium wykonuję określoną akcję.
        
* **Wyjście**:
      - Użytkowik/Użytkownik premium otrzymuję określoną ilość punktów w zależności od wykonanej akcji.
      - Użytkowik/Użytkownik premium otrzymuje komunikat o ilości otrzymanych punktów.
        
* **Główny scenariusz**:
      Użytkowik/Użytkownik premium wykonuje określone akcje np. złożenie zamówienia / wypożyczenie książki. Za sfinalizowanie akcji otrzymuje określoną ilośc punktów na swoje konto.
        
* **Kroki**:

        - Krok 1: Użytkowik/Użytkownik premium wykonuje określoną akcję
        - Krok 2: Po jej zakończeniu punkty automatycznie są dopisywane do konta w odpowiedniej ilości.

       

* **Przykład**:

----zdobywanie_punktów.png------

- - -

### Wydawanie punktów

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium wymiany zebranych punktów na określone nagrody(ksiązki / kody rabatowe).
     
* **Wejście**:
        Użytkownik/Użytkownik premium wybiera sposób wykorzystania punktów.
        
* **Wyjście**:
        - Użytkownik/Użytkownik premium traci pewną ilość punktów.
        -  Użytkownik/Użytkownik premium otrzymuje określoną nagordę.
        
* **Główny scenariusz**:
      Użytkownik/Użytkownik premium po zebraniu określonej ilości punktów wyraża chęć ich wykorzystania. Wybiera zakładkę
        
* **Kroki**:

        - Krok 1.1: Użytkownik/Użytkownik premium 

       

* **Przykład**:

----wydawanie_punktów.png------

- - -

### Dodanie pozycji do systemu

* **Cel**: 
        
     
* **Wejście**:
        
        
* **Wyjście**:
      
        
* **Główny scenariusz**:
      
        
* **Kroki**:

        - Krok 1: 

       

* **Przykład**:

----dodanie_pozycji_do_systemu.png------

- - -

### Modyfikowanie pozycji z systemu

* **Cel**: 
        
     
* **Wejście**:
        
        
* **Wyjście**:
      
        
* **Główny scenariusz**:
      
        
* **Kroki**:

        - Krok 1: 

       

* **Przykład**:

----modyfikowanie_pozycji_z_systemu.png------

- - -



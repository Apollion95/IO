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
      Użytkownik/Użytkownik premium po zebraniu określonej ilości punktów wyraża chęć ich wykorzystania. 
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium wchodzi w zakładkę "Punkty".
        
        - Krok 2.1.1: Użytkownik/Użytkownik premium wybiera opcję uzyskania rabatu.
        
        - Krok 2.1.2: Użytkownik/Użytkownik premium wybiera określony rabat oraz go zatwierdza.
        
        - Krok 2.1.3: Użytkownik/Użytkownik premium otrzymuje kod, który może wykorzystać w zamówieniu

        /
        
        - Krok 2.2.1: Użytkownik/Użytkownik premium wybiera opcję otrzymania określonej pozycji.
        
        - Krok 2.2.2: Użytkownik/Użytkownik premium wybiera pozycję z określonej puli.
        
        - Krok 2.2.3: Użytkownik/Użytkownik premium zatwierdza swój wybór.
       

* **Przykład**:

----wydawanie_punktów.png------

- - -

### Dodanie pozycji do systemu

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie powiększenia ilości udostępnianych zasobów dostępnych w systemie.
     
* **Wejście**:
        Administrator zatwierdza odpowiedni formularz.
        
* **Wyjście**:
        Administrator otrzymuje komunikat o pomyślnym dodaniu zasobu lub komunikat o błędzie .
        
* **Główny scenariusz**:
      Administrator otrzymuje zasób do udostępnienia w systemie. Po zalogowaniu do systemu wchodzi w odpowiednią zakładkę. Wypełnia formularz (tytuł/autor/isbn..) oraz dodaje zasób, po czym zatwierdza formularz. 
        
* **Kroki**:

        - Krok 1: Administrator otrzymuje zasób.
        
        - Krok 2: Administrator uruchamia odpowiedni formularz.
        
        - Krok 3: Administrator wypełnia formularz.
        
        - Krok 4: Administrator ładuje zasób.
        
        - Krok 5: Administrator zatwierdza zasób.

       

* **Przykład**:

----dodanie_pozycji_do_systemu.png------

- - -

### Modyfikowanie pozycji z systemu

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie zmianę zbioru danych które definiują dany zasób(autor, tytuł, ISBN).
     
* **Wejście**:
        Administrator modyfikuje poszczególne dane.
        
* **Wyjście**:
         Administrator otrzymuje komunikat o pomyślnej  modyfikacji zasobu lub komunikat o błędzie.
        
* **Główny scenariusz**:
      Administrator otrzymuje informację o zmianie danych identyfikujących dany zasób. Przeszukuje system w poszukiwaniu określonego zasobu oraz w momencie znalezienia modyfikuje określone informacje.
        
* **Kroki**:

        - Krok 1: Administrator przeszukuje system w poszukiwaniu określonej pozycji.
        
        - Krok 2: Administrator modyfikuje określone pola.
        
        - Krok 3: Administrator zatwierdza wprowadzone modyfikacje.

       

* **Przykład**:

----modyfikowanie_pozycji_z_systemu.png------

- - -


### Usuwanie pozycji z systemu

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie usunięcia poszczególnych zasobów z systemu.
     
* **Wejście**:
        Administrator zatwierdza usunięcie pozycji.
        
* **Wyjście**:
        Administrator otrzymuje komunikat o pomyślnym usunięciu lub komunikat o błędzie.
        
* **Główny scenariusz**:
            Administrator otrzymuje informację o potrzebie usunięcia danego zasobu z systemu. Administrator wyszukuje odpowiedni zasób, wybiera opcję usunięcia po czym ją zatwierdza.
        
* **Kroki**:

        - Krok 1: Administrator przeszukuje system w poszukiwaniu określonej pozycji.
        
        - Krok 2: Administrator wybiera opcję usunięcia.
        
        - Krok 3: Administrator zatwierdza usunięcie pozycji.
       

* **Przykład**:

----usuwanie_pozycji_z_systemu.png------

- - -


### Tryb czytania

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie użytkownikowi/użytkownikowi premium/administratorowi skorzystanie z zasobu w postaci trybu do czytania.
     
* **Wejście**:
       Użytkownik/Użytkownik premium/Administrator wybiera dany zasób.
        
* **Wyjście**:
        Użytkownik/Użytkownik premium/Administrator otrzymuje dany zasób w trybie "do czytania".
        
* **Główny scenariusz**:
        Użytkownik/Użytkownik premium/Administrator chce skorzystać z zasobu, w tym celu przechodzi do odpowiedniej zakładki i wybiera interesującą go pozycje.
        
* **Kroki**:

        Użytkownik / Użytkownik premium:
        
        - Krok 1: Wybiera zakładkę biblioteczka.
        
        - Krok 2: Wyszukuje interesującą go pozcyję.
        
        - Krok 3: Uruchamia tryb "do czytania".

        Administrator:
        
        - Krok 1: Wyszukuje określoną pozycję.
        
        - Krok 2: Uruchamia tryb "do czytania".

* **Przykład**:

----tryb_czytania.png------

- - -


### Przeglądanie użytkowników

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie Administratorowi przeglądanie użytkowników w postaci listy lub w postaci indywidualnej celem późniejszych modyfikacji.
     
* **Wejście**:
        Adminstrator wyszukuje określonego użytkownika / grupę przy pomocy fraz i filtrów.
        
* **Wyjście**:
        Określony użytkownik / Kolekcja użytkowników / Komunikat o nie znalezieniu.
        
* **Główny scenariusz**:
        Administrator wybiera zakładkę przeszukania bazy w celu znalezienia określonego użytkownika lub grupy użytkowników. 
        
* **Kroki**:

        - Krok 1: Administrator wybiera zakładkę przeszukania bazy użytkowników
        
        - Krok 2: Administrator wpisuje określoną frazę do odnalezienia.
        
        - Krok 3: **(opcjonalnie)** Stosuje określone filtry w celu zawężenia wyników.
        
       

* **Przykład**:

----przeglądanie_użytkowników.png------

- - -


### Usuwanie użytkowników

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie Administratorowi usunięcie danych użytkownika z systemu.
     
* **Wejście**:
        Administrator wybiera opcję usunięcia konta.
        
* **Wyjście**:
        Komunikat o pomyślnym usunięciu konta i powiązanych danych lub komunikat o błędzie.
        
* **Główny scenariusz**:
        Administrator otrzymuje zgłoszenie od klienta z prośbą o usunięcie konta. Administrator przeszukuje bazę użytkowników. Po znalezieniu określonego użytkownika wybiera opcję usunięcia .
        
* **Kroki**:

        - Krok 1: Administrator otrzymuje zgłoszenie.
        
        - Krok 2: Administrator wyszukuje określonego użytkownika.
        
        - Krok 3: Administrator wybiera opcję usunięcia.
        
        - Krok 4: Administrator potwierdza wykonywaną operację.
       

* **Przykład**:

----usuwanie_użytkowników.png------

- - -


### Przyjmowanie zgłoszeń

* **Cel**: 
        Celem tej funkcjonalności jest umożliwienie przyjmowanie zgłoszeń przez administratora otrzymanych od użytkowników/użytkowników premium systemu.
     
* **Wejście**:
        Administrator potwierdza przyjęcie zgłoszenia.
        
* **Wyjście**:
        Administrator zostaje przypisany do zgłoszenia.
        
* **Główny scenariusz**:
    Po otrzymaniu zgłoszeń od użytkowników, administrator wybiera dane zgłoszenie i przypisuje się do niego.
        
* **Kroki**:

        - Krok 1: Administrator wchodzi w panel zgłoszeń.
        
        - Krok 2: Administrator wybiera określone zgłoszenie.
        
        - Krok 3: Administrator potwierdza przypisanie
        
        - Krok 4: Administrator zostaje przypisany do zgłoszenia
       

* **Przykład**:

----zgłoszenia.png------

- - -


### Biblioteczka

* **Cel**: 
        Celem tej funkcjonalności jest umożliwnie użytkownikom/użytkownikom premium przeglądniecię pozycji do których uzyskali dostęp oraz za pomocą tej funkcjonalności przejście to trybu "do czytania".
     
* **Wejście**:
        Użytkownik/Użytkownik premium wybiera zakładkę "Biblioteczka".
        
* **Wyjście**:
        Użytkownik/Użytkownik premium otrzymuję kolekcję zasobów do których ma przyznany dostęp.
        
* **Główny scenariusz**:
        Użytkownik/Użytkownik premium chce skorzystać z posiadanych zasobów, w tym celu wybiera odpowiednią zakładkę oraz wyszukuje określoną pozycję.
        
* **Kroki**:

        - Krok 1: Użytkownik/Użytkownik premium wybiera zakładkę "Biblioteczka"
        
        - Krok 2: Użytkownik/Użytkownik premium otrzymuje kolekcję pozycji do który posiada dostęp.
        
        - Krok 3: **(opcjonalnie)** Użytkownik/Użytkownik premium wybiera określoną pozycję której szukał w celu uruchomienia trybu "do czytania".
       

* **Przykład**:

----biblioteczka.png------

- - -


### Zakup subskrypcji

* **Cel**: 
        - Użytkownik otrzymuje możliwość zakupienia miesięcznej subskrybcji(indywidualnej/grupowej) w celu otrzymania statusu "premium" oraz otrzymując tym samym następujące bonusy: 
          - Otrzymanie określonej ilości pozycji za darmo(ich pula zmienia się co miesiąc)
          - Dodatkowe zniżki
          - Możliwość zakupienia określonych pozycji przedpremierowo 
          - Dodatkowej ilości przyznawanych punktów za doładowania
        - Użytkownik premium otrzymuje możliwość przedłużenia już posiadanej subskrypcji.
        
     * Subskrypcja indywidualna - dla użytkownika kupującego.
     * Subskrypcja grupowa - po zakupie pozwala na dodanie innych użytkowników do grupy tym samym użytkownicy dodani otrzymują status "Premium" oraz wszystkie benefity z tym związane.

        
     
* **Wejście**:
        Użytkownik/Użytkownik premium wybiera zakładkę "Premium".
        
* **Wyjście**:
        - Użytkownik otrzymuje status premium lub komunikat o niepowodzeniu.
        - Użytkownik premium otrzymuje przedłużenie swojej subskrypcji lub komunikat o niepowodzeniu.
        
* **Główny scenariusz**:
        Użytkownik/Użytkownik premium chce skorzystać z funkcji premium/przedłużyć subskrypcję, wybiera odpowiednią zakładkę oraz potwierdza transakcję.
        
       
        
* **Kroki**:

        - Krok 1:  Użytkownik/Użytkownik premium wybiera zakładkę "premium"

        Użytkownik:
        
        - Krok 1.1.1: Wybiera jeden z dostępnych typów subskrypcji.
        
        - Krok 1.1.2: Klika przycisk "Kup".
       
       - Krok 1.1.3: Zatiwerdza sfinalizowanie transakcji.

        Użytkownik premium:
        
        - Krok 1.2.1: Wybiera opcję przedłużenia subskrypcji
        
        - Krok 1.2.2: Klika przycisk "Kup".
       
       - Krok 1.2.3: Zatiwerdza sfinalizowanie transakcji.
       

* **Przykład**:

----subskrypcja.png------

- - -


### Dodanie użytwkonika do grupy subskrypcji

* **Cel**: 
        
     
* **Wejście**:
        
        
* **Wyjście**:
        
        
* **Główny scenariusz**:
    .
        
* **Kroki**:

        - Krok 1: 
       

* **Przykład**:

----modyfikowanie_pozycji_z_systemu.png------

- - -


### Wypożyczenie pozycji

* **Cel**: 
        
     
* **Wejście**:
        
        
* **Wyjście**:
        
        
* **Główny scenariusz**:
    .
        
* **Kroki**:

        - Krok 1: 
       

* **Przykład**:

----wypożyczenie.png------

- - -


### Modyfikowanie pozycji z systemu

* **Cel**: 
        
     
* **Wejście**:
        
        
* **Wyjście**:
        
        
* **Główny scenariusz**:
    .
        
* **Kroki**:

        - Krok 1: 
       

* **Przykład**:

----modyfikowanie_pozycji_z_systemu.png------

- - -

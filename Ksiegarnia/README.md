# Konfiguracja

W celu poprawnego działania projektu należy:

* Sklonować repozytorium.
* Posiadać zainstalowany serwer MySQL bezpośrednio na urządzeniu lub na dockerze.
* Zaktualizować **connectionString** znajdujący się w pliku **appsettings.json** dostosowując parametry połączenia do swoje serwera MySQL.
* Wykonać pierwszą migrację za pomocą polecenia **update-database** w kosnoli menadżera pakietów NuGet.
* Sprawdzić poprawność zainstalowanych pakietów z sekcji **Pakiety** poprzez wybranie opcji **Zarządzaj pakietami NuGet rozwiązania** w menu Visual Studio.

- - - - - 

## Pakiety 

* **Pomelo.EntityFrameworkCore.MySql** - dostawa bazy danych MySQL dla EntityFramework Core.
* **System.Configuration.ConfigurationManager** - zapewnia typy, które obsługują używanie plików konfiguracyjnych.
* **PagedList** - pakiet odpowiedzialny za ułatwienie tworzenia paginacji wraz z zapewnieniem wsparcia przy tworzeniu kontrolek stronnicowania.
* **Microsoft.EntityFrameworkCore.Tools** - dostarcza podstawowe narzędzia EntityFramework dla menadżera pakietów NuGet.
* **Microsoft.EntityFrameworkCore.Design** - zawiera logikę projektownia dla Entity Framework Core, do której odwołują się takie polecenia jak m.in  **add-migration "name"**.
* **Microsoft.EntityFrameworkCore** - pakiet odpowiedzialny za mapowania encji do bazy danych, obsługujący zapytania LINQ, śledzenie zmian, aktualizację obiektów oraz migrację.
* **Microsoft.CodeAnalysis.Common** - pakiet odpowiedzialny za dostarczenie typu Optional<T> pomocnego przy tworzeniu m.in repozytoriów.
* **Microsoft.AspNetCore.SpaProxy** - pakiet pomocniczy, wykorzystywany  do automatycznego uruchamiania serwera proxy SPA CLI podczas uruchamiania aplikacji w ASP.NET MVC Core.
* **Microsoft.ApsNetCore.Identity.EntityFrameworkCore** - Zapewnia typy utrwalania danych tożsamości za pomocą Entity Framework Core.

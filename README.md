# Blazor primjeri za AUP (2022/23)

.NET 7.0.

Uključeno je sljedeće:

* Primjeri za EditForm - nije potrebno znati, možete koristiti za projekt
* Primjer tablice (nakon unesenog studenta u popis), odmah se osvježava tablica
* Primjeri  za Bootstrap - nije potrebno znati, ne morate koristiti za projekt

Razlika u odnosu na običnu formu (`<form></form>`) je u tome što EditForm ima neke funkcionalnosti već ugrađene (npr. provjeru je li neki podatak obavezan - Required). Ako nisu upisani obavezni podaci, onda forma neće završiti unos. 

Napomene: 
* Ako nekome bude potreban unos podataka iz json datoteke, možete koristiti ideju/primjer iz `FetchData.razor` dokumenta ili se javite mailom za primjer sa studentima.
* U ovom pristupu nećemo koristiti klasični pristup rada s tekstualnim datotekama jer se radi o web aplikaciji koja na taj način ne može trajno spremiti neku datoteku na vaše računalo. Za ulaz možete koristiti unaprijed pripremljene podatke kao što je `wwwroot/sample-data/weather.json`, ili "zalijepiti" tekst u `textarea` pa ga obraditi kao string, a za izlaz je najjednostavnije ispisati rezultat u `textarea` koji prihvaća `\n` kao novu liniju.

## Izrada jednostavne Blazor WebAssembly aplikacije

Novu Blazor WASM aplikaciju stvaramo upisivanjem naredbe u terminal:
```
dotnet new blazorwasm
```

Kompajliranje i provjera:
```
dotnet build
```

Pokretanje aplikacije:
```
dotnet run
```

Drugi način za pokretanje:
```
dotnet watch
```

Važne je zapamtiti:
* CTRL + C (prekid rada)
* CTRL + R (ponovno učitavanje - za watch)
* CTRL + Space (nadopunjavanje koda)

## Preporučene ekstenzije za Blazor

* C# - [ms-dotnettools.csharp](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
* Blazor Snippet Pack - [adrianwilczynski.blazor-snippet-pack](https://marketplace.visualstudio.com/items?itemName=adrianwilczynski.blazor-snippet-pack)

## Upute

Upute možete pronaći na Microsoft-ovim stranicama, npr. [learn.microsoft.com](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms-and-input-components?view=aspnetcore-7.0)


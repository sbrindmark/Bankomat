# Bankomat

Ett konsolprogram i C# som simulerar en enkel bankomat med inloggning via PIN-kod, ins�ttning, uttag och saldokontroll.

## Funktioner

- **Inloggning med PIN-kod:** Anv�ndaren m�ste ange en fyrsiffrig PIN-kod (h�rd kodad till `1337`) f�r att anv�nda bankomaten. Max 3 f�rs�k.
- **Menyval:**
  - S�tt in pengar
  - Ta ut pengar
  - Visa saldo
  - Avsluta programmet
- **Validering:**
  - Uttag f�r inte �verstiga saldo.
  - Belopp m�ste vara numeriskt och st�rre �n 0.

## Objektorienterad struktur

- **Person:** Hanterar namn och personnummer (readonly).
- **BankAccount:** Hanterar saldo och metoder f�r ins�ttning/uttag med validering.
- **Customer:** Kopplar ihop Person, BankAccount och PIN-kod. Har autentiseringsmetod.

## Kom ig�ng

### Bygg och k�r

1. Klona projektet:
2. �ppna i Visual Studio 2022.
3. Bygg och k�r projektet (`.NET 8`, C# 12).

### Anv�ndning

1. Starta programmet.
2. Ange PIN-kod (`1337`).
3. V�lj �nskad funktion i menyn.

## Exempel

## Kodstruktur

- `Program.cs` � Huvudlogik och menyhantering
- `Person.cs` � Personuppgifter
- `BankAccount.cs` � Kontohantering
- `Customer.cs` � Kund och autentisering

## Licens

MIT
# Bankomat

Ett konsolprogram i C# som simulerar en enkel bankomat med inloggning via PIN-kod, insättning, uttag och saldokontroll.

## Funktioner

- **Inloggning med PIN-kod:** Användaren måste ange en fyrsiffrig PIN-kod (hård kodad till `1337`) för att använda bankomaten. Max 3 försök.
- **Menyval:**
  - Sätt in pengar
  - Ta ut pengar
  - Visa saldo
  - Avsluta programmet
- **Validering:**
  - Uttag får inte överstiga saldo.
  - Belopp måste vara numeriskt och större än 0.

## Objektorienterad struktur

- **Person:** Hanterar namn och personnummer (readonly).
- **BankAccount:** Hanterar saldo och metoder för insättning/uttag med validering.
- **Customer:** Kopplar ihop Person, BankAccount och PIN-kod. Har autentiseringsmetod.

## Kom igång

### Bygg och kör

1. Klona projektet:
2. Öppna i Visual Studio 2022.
3. Bygg och kör projektet (`.NET 8`, C# 12).

### Användning

1. Starta programmet.
2. Ange PIN-kod (`1337`).
3. Välj önskad funktion i menyn.

## Exempel

## Kodstruktur

- `Program.cs` – Huvudlogik och menyhantering
- `Person.cs` – Personuppgifter
- `BankAccount.cs` – Kontohantering
- `Customer.cs` – Kund och autentisering

## Licens

MIT
// ZAD-1
// Zadanie 1. Pierwsze komunikaty

// Napisz program, który wyświetli w osobnych wierszach powitanie, Twoje imię, nazwę kierunku studiów oraz zdanie opisujące, czego chcesz nauczyć się na kursie. Użyj co najmniej raz Console.Write i co najmniej raz Console.WriteLine.
//Console.WriteLine("Witaj\nMaciej Stencel\nInformatyka\nNa kursie chcę się nauczyć prawidłowo programować w C#");



// ZAD-2
// Zapisz imię, wiek i ulubioną grę w trzech zmiennych o odpowiednich typach. Następnie wyświetl estetyczną wizytówkę, korzystając z interpolacji tekstu.

// Console.WriteLine("+-----------------------+");
// Console.WriteLine("|\tWIZYTÓWKA\t|");
// Console.WriteLine("+-----------------------+");
// Console.WriteLine("|\tImię: Maciej\t|");
// Console.WriteLine("|\tWiek: 20\t|");
// Console.WriteLine("|\tGra: RDR2\t|");
// Console.WriteLine("+-----------------------+");



// ZAD-3
// Zapytaj użytkownika o imię i ulubiony kolor. Zapisz obie odpowiedzi w zmiennych, a potem wyświetl spersonalizowane powitanie w jednym zdaniu.

// string imie;
// Console.WriteLine("Jak masz na imię?");
// imie = Console.ReadLine();
// 
// string color;
// Console.WriteLine("Jaki jest twój ulubiony kolor?");
// color = Console.ReadLine();
// 
// Console.WriteLine("Cześć " + imie + "! Twój ulubiony kolor to " + color + ".");



// ZAD-4
// Pobierz od użytkownika jego wiek jako liczbę całkowitą. Oblicz i wyświetl, ile lat będzie miał za rok oraz za pięć lat.

// Console.Write("Podaj wiek: ");
// string UserInput = Console.ReadLine()!;
// int age = int.Parse(UserInput);
// 
// Console.WriteLine($"Za rok będziesz mieć {age + 1} lat oraz za 5 lat twój wiek będzie wynosił {age + 5}.");



// ZAD-5
// Zapytaj o liczbę kilometrów do celu oraz liczbę kilometrów pokonywanych każdego dnia. Oblicz, przez ile dni trwałaby podróż, zakładając, że obie liczby dzielą się bez reszty. Wyświetl podsumowanie zawierające dane i wynik.

// Console.Write("Podaj liczbę kilometrów do celu: ");
// string DistanceInput = Console.ReadLine()!;
// int Distance = int.Parse(DistanceInput);
// 
// Console.Write("Podaj liczbę kilometrów pokonywanych każdego dnia: ");
// string DailyDistanceInput = Console.ReadLine()!;
// int DailyDistance = int.Parse(DailyDistanceInput);
// 
// int DaysToReachEnd = Distance / DailyDistance;
// Console.WriteLine($"Żeby dotrzeć do celu potrzebujesz {DaysToReachEnd} dni.");



// ZAD-6
// Pobierz liczbę złotych, srebrnych i miedzianych monet. Przyjmij, że jedna złota moneta jest warta 100 miedzianych, a jedna srebrna — 10 miedzianych. Oblicz łączną wartość sakiewki wyrażoną w miedzianych monetach.

// Console.Write("Podaj ilość miedzianych monet: ");
// string CopperCoinsInput = Console.ReadLine()!;
// int CopperCoins = int.Parse(CopperCoinsInput);
// 
// Console.Write("Podaj ilość srebrnych monet: ");
// string SilverCoinsInput = Console.ReadLine()!;
// int SilverCoin = int.Parse(SilverCoinsInput);
// 
// Console.Write("Podaj ilość złotych monet: ");
// string GoldCoinsInput = Console.ReadLine()!;
// int GoldCoins = int.Parse(GoldCoinsInput);
// 
// int GoldValue = 100 * GoldCoins;
// int SilverValue = 10 * SilverCoin;
// int CopperValue = CopperCoins;
// 
// int TotalValue = GoldValue + SilverValue + CopperValue;
// Console.WriteLine($"Łączna wartość sakiewki wynosi {TotalValue} miedzianych monet.");



// ZAD-7
// Jedna mikstura wymaga 3 kryształów i 2 ziół. Pobierz liczbę mikstur, które chce przygotować użytkownik, a następnie oblicz łączną liczbę potrzebnych kryształów i ziół. Wynik przedstaw jako czytelną listę składników.

// Console.Write("Ilość mikstur, które chcesz przygotować: ");
// string PotionsInput = Console.ReadLine()!;
// int Potions = int.Parse(PotionsInput);
// 
// int CrystalsNeeded = 3 * Potions;
// int HerbsNeeded = 2 * Potions;
// Console.WriteLine($"Do przygotowania {Potions} mikstur potrzebujesz {CrystalsNeeded} kryształów i {HerbsNeeded} ziół.");



// ZAD-8
// Pobierz cenę noclegu oraz liczbę nocy. Oblicz koszt całego pobytu. Cenę przechowuj w zmiennej typu decimal, a liczbę nocy w zmiennej typu int.

// Console.Write("Podaj osiągalną cenę noclegu w PLN: ");
// string PlacePriceInput = Console.ReadLine()!;
// decimal PlacePrice = decimal.Parse(PlacePriceInput);
// 
// Console.Write("Podaj liczbę dni zakwaterowania: ");
// string NumberOfDaysInput = Console.ReadLine()!;
// int NumberOfDays = int.Parse(NumberOfDaysInput);
// 
// decimal TotalCost = (decimal)PlacePrice * NumberOfDays;
// Console.WriteLine($"Łączny koszt zakwaterowania wynosi {TotalCost} złotych.");



// ZAD-9
// Pobierz całkowitą liczbę sekund, a następnie przedstaw ten czas jako liczbę pełnych minut i pozostałych sekund. Przykład: dla 154 sekund program powinien wyświetlić 2 minuty i 34 sekundy.

// Console.Write("Podaj liczbę sekund: ");
// string SecondsInput = Console.ReadLine()!;
// int Seconds = int.Parse(SecondsInput);
// 
// int Minutes = Seconds / 60;
// int ResultingSeconds = Seconds % 60;
// 
// Console.WriteLine($"Podana liczba sekund to {Minutes} minut i reszta {ResultingSeconds} sekund.");



// ZAD-10
// Drużyna zdobyła skarb składający się ze złotych monet. Pobierz liczbę monet oraz liczbę bohaterów. Oblicz, ile pełnych monet otrzyma każdy bohater oraz ile monet pozostanie po równym podziale. Program nie musi obsługiwać sytuacji, w której liczba bohaterów wynosi zero.

// Console.Write("Podaj liczbę monet: ");
// string CoinsValue = Console.ReadLine()!;
// 
// Console.Write("Podaj liczbę bohaterów: ");
// string HeroesValue = Console.ReadLine()!;
// 
// int Coins = int.Parse(CoinsValue);
// int Heroes = int.Parse(HeroesValue);
// 
// int FinalSplit = Coins / Heroes;
// int RestCoins = Coins % Heroes;
// Console.WriteLine($"Każdy bohater otrzyma {FinalSplit} monet.");
// Console.WriteLine($"Pozostaje {RestCoins} niepodzielonych monet.");



// ZAD-11
// Pobierz wartość podstawowych obrażeń broni i premię do siły. Oblicz obrażenia zwykłego ataku jako sumę obu wartości, obrażenia ataku specjalnego jako dwukrotność zwykłego ataku oraz łączne obrażenia trzech zwykłych ataków i jednego specjalnego. Wyświetl wszystkie etapy obliczeń w czytelnym raporcie.

// Console.Write("Podaj wartość podstawowych obrażeń broni: ");
// string BaseDamageInput = Console.ReadLine()!;
// int BaseDamage = int.Parse(BaseDamageInput);
// 
// 
// Console.Write("Podaj wartość premii do siły: ");
// string StrengthBonusInput = Console.ReadLine()!;
// int StrengthBonus = int.Parse(StrengthBonusInput);
// 
// // attack types
// int BasicAttack = BaseDamage + StrengthBonus;
// int SpecialAttack = 2 * BasicAttack;
// int TotalDamage = (BasicAttack * 3) + SpecialAttack;
// 
// Console.WriteLine($"Obrażenia zwykłego ataku: {BasicAttack}");
// Console.WriteLine($"Obrażenia ataku specjalnego: {SpecialAttack}");
// Console.WriteLine($"Łączne obrażenia: {TotalDamage}");



// //ZAD-12
// // Pobierz nazwę bohatera, nazwę krainy, liczbę dni wyprawy, liczbę zdobytych punktów doświadczenia i ilość zebranego złota. Oblicz średnią liczbę punktów doświadczenia oraz złota zdobytych jednego dnia. Dobierz typy pozwalające wyświetlić wyniki z częścią ułamkową, a następnie pokaż dane w formie kilkulinijkowego wpisu do dziennika.
// 
// //  HeroName
// Console.Write("Podaj nazwę bohatera: ");
// String HeroName = Console.ReadLine()!;
// // KingdonName
// Console.Write("Podaj nazwę krainy: ");
// String KingdomName = Console.ReadLine()!;
// // Days
// Console.Write("Podaj liczbę dni wyprawy: ");
// String DaysInput = Console.ReadLine()!;
// int Days = int.Parse(DaysInput);
// // Experience
// Console.Write("Podaj liczbę zdobytych punktów doświadczenia: ");
// string ExperienceInput = Console.ReadLine()!;
// int Experience = int.Parse(ExperienceInput);
// decimal AverageExperience = (decimal)Experience / Days;   
// // Gold
// Console.Write("Podaj ilość zebranego złota ");
// string GoldInput = Console.ReadLine()!;
// int Gold = int.Parse(GoldInput);
// decimal AverageGold = (decimal)Gold / Days;
// 
// Console.WriteLine($"Bohater {HeroName} w krainie {KingdomName} podczas {Days} dni wyprawy zdobył {Experience} punktów doświadczenia.\nDaje to średnio {AverageExperience} punktów doświadczenia na dzień.\nDodatkowo zebrał {Gold} złota, co daje średnio {AverageGold} złota na dzień.");



// ZAD-13
// Zadanie projektowe — „Hello Adventurer”. Utwórz konsolowy program wyświetlający spersonalizowaną kartę bohatera rozpoczynającego przygodę.

// Player Name
Console.Write("Podaj imię gracza: ");
String PlayerName = Console.ReadLine()!;
// Health
Console.Write("Podaj liczbę punktów życia: ");
String HealthPoints = Console.ReadLine()!;
int Health = int.Parse(HealthPoints);
// Energy
Console.Write("Podaj ilość energii: ");
String EnergyPoints = Console.ReadLine()!;
int Energy = int.Parse(EnergyPoints);
// Money
Console.Write("Podaj ilość pieniędzy: ");
String MoneyInput = Console.ReadLine()!;
decimal Money = decimal.Parse(MoneyInput);
// Honor
Console.Write("Podaj ilość Honoru: ");
String HonorInput = Console.ReadLine()!;
int Honor = int.Parse(HonorInput);

// Math
int HealthWithBonus = Health + Energy / 10 * 2;
decimal MoneyWithBonus = Money + Honor / 10 * 5;


// Final
Console.WriteLine("+===============================+");
Console.WriteLine("|Tytuł Gry:Red Dead Redemption 2|");
Console.WriteLine("+===============================+");
Console.WriteLine($"|\tGracz: {PlayerName}\t\t|");
Console.WriteLine($"|\tPunkty życia: {Health}\t|");
Console.WriteLine($"|\tPieniądze: {Money}\t\t|");
Console.WriteLine($"|\tEnergia: {Energy}\t\t|");
Console.WriteLine($"|\tHonor: {Honor}\t\t|");
Console.WriteLine("+==========|PO BONUSIE|=========+");
Console.WriteLine($"|\tPunkty życia: {HealthWithBonus}\t|");
Console.WriteLine($"|\tPieniądze: {MoneyWithBonus}\t\t|");
Console.WriteLine("+===============================+");
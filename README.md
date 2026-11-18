Budżet osobisty
Nazwa projektu
Budżet osobisty
Opis projektu
Budżet osobisty to prosta aplikacja konsolowa napisana w języku C#. Jej zadaniem będzie pomaganie użytkownikowi w kontrolowaniu wydatków i zarządzaniu pieniędzmi.
Użytkownik będzie mógł ustawić początkowy budżet, dodawać wydatki, wyświetlać ich listę oraz usuwać niepotrzebne wpisy. Program będzie automatycznie obliczał sumę wszystkich wydatków i pokazywał, ile pieniędzy pozostało.
Aplikacja będzie przeznaczona dla osób, które chcą w prosty sposób kontrolować swoje codzienne wydatki i sprawdzać, na co przeznaczają pieniądze.
Główne funkcjonalności
Program będzie posiadał następujące funkcje:
Ustawianie budżetu – użytkownik będzie mógł podać kwotę pieniędzy, którą ma do dyspozycji.
Dodawanie wydatków – użytkownik będzie mógł wpisać nazwę wydatku i jego kwotę.
Wyświetlanie wydatków – program pokaże listę zapisanych wydatków wraz z ich kwotami.
Usuwanie wydatków – użytkownik będzie mógł usunąć wybrany wydatek z listy.
Obliczanie sumy wydatków – program automatycznie obliczy łączną kwotę wszystkich wydatków.
Sprawdzanie pozostałego budżetu – program obliczy, ile pieniędzy pozostało po odjęciu wydatków od początkowego budżetu.
Podsumowanie budżetu – użytkownik będzie mógł wyświetlić budżet początkowy, sumę wydatków i pozostałą kwotę.
Sprawdzanie poprawności danych – program nie pozwoli na dodanie wydatku z pustą nazwą lub nieprawidłową kwotą.
Technologie
W projekcie zostaną wykorzystane następujące technologie:
Język programowania: C#
Platforma: .NET
Środowisko programistyczne: Visual Studio lub Visual Studio Code
Interfejs użytkownika: konsola tekstowa
Przechowywanie danych: lista obiektów w pamięci programu
Baza danych: nie będzie wykorzystywana
Dodatkowe biblioteki: nie będą potrzebne
Dane będą przechowywane w pamięci programu podczas jego działania. Po zamknięciu aplikacji wprowadzone dane nie będą zachowywane.
Plan struktury programu
Program będzie składał się z jednego głównego pliku Program.cs, w którym zostaną umieszczone najważniejsze elementy aplikacji.
Planowane elementy programu:
Element	Odpowiedzialność
Program	Główna klasa programu, obsługa menu i sterowanie działaniem aplikacji
Expense	Klasa przechowująca nazwę i kwotę pojedynczego wydatku
List<Expense>	Lista przechowująca wszystkie dodane wydatki
SetBudget()	Ustawianie początkowego budżetu
AddExpense()	Dodawanie nowego wydatku
ShowExpenses()	Wyświetlanie listy wydatków
DeleteExpense()	Usuwanie wybranego wydatku
ShowSummary()	Obliczanie i wyświetlanie podsumowania budżetu
Planowana struktura plików:
BudzetOsobisty/
├── Program.cs
├── BudzetOsobisty.csproj
└── README.md
Plik Program.cs będzie zawierał kod aplikacji, plik BudzetOsobisty.csproj będzie przechowywał ustawienia projektu .NET, a plik README.md będzie zawierał dokumentację.
Interfejs aplikacji
Aplikacja będzie posiadała prosty interfejs tekstowy wyświetlany w konsoli. Użytkownik będzie wybierał funkcje za pomocą numerów.
Przykładowy wygląd menu głównego:
================================
BUDZET OSOBISTY
Ustaw budzet
Dodaj wydatek
Wyswietl wydatki
Usun wydatek
Podsumowanie budzetu
Zakoncz program
Wybierz opcje:
Przykładowy wygląd listy wydatków:
========== WYDATKI ==========
Jedzenie - 120,00 zl
Transport - 80,00 zl
Rozrywka - 50,00 zl
Suma wydatkow: 250,00 zl
Pozostaly budzet: 750,00 zl
Po wykonaniu wybranej operacji program będzie wracał do menu głównego. Aplikacja zakończy działanie po wybraniu opcji 0.
Plan działania
Projekt będzie realizowany w następujących etapach:
Utworzenie nowego projektu konsolowego w języku C#.
Przygotowanie podstawowej struktury programu i menu głównego.
Utworzenie klasy Expense do przechowywania informacji o wydatkach.
Przygotowanie listy przechowującej wydatki.
Implementacja funkcji ustawiania budżetu.
Implementacja dodawania i wyświetlania wydatków.
Implementacja usuwania wybranego wydatku.
Dodanie obliczania sumy wydatków i pozostałego budżetu.
Dodanie sprawdzania poprawności wprowadzanych danych.
Przetestowanie wszystkich funkcji programu i poprawienie ewentualnych błędów.
Przygotowanie dokumentacji projektu w pliku README.md.

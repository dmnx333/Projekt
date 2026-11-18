Budżet osobisty

1. Nazwa projektu

Budżet osobisty

2. Opis projektu

Budżet osobisty to prosta aplikacja konsolowa napisana w języku C#. Jej zadaniem będzie pomaganie użytkownikowi w kontrolowaniu wydatków i zarządzaniu pieniędzmi.

Użytkownik będzie mógł ustawić początkowy budżet, dodawać wydatki, wyświetlać ich listę oraz usuwać niepotrzebne wpisy. Program będzie automatycznie obliczał sumę wszystkich wydatków i pokazywał, ile pieniędzy pozostało.

Aplikacja będzie przeznaczona dla osób, które chcą w prosty sposób kontrolować swoje codzienne wydatki i sprawdzać, na co przeznaczają pieniądze.

3. Główne funkcjonalności

Program będzie posiadał następujące funkcje:

* Ustawianie budżetu – użytkownik będzie mógł podać kwotę pieniędzy, którą ma do dyspozycji.
* Dodawanie wydatków – użytkownik będzie mógł wpisać nazwę wydatku i jego kwotę.
* Wyświetlanie wydatków – program pokaże listę zapisanych wydatków wraz z ich kwotami.
* Usuwanie wydatków – użytkownik będzie mógł usunąć wybrany wydatek z listy.
* Obliczanie sumy wydatków – program automatycznie obliczy łączną kwotę wszystkich wydatków.
* Sprawdzanie pozostałego budżetu – program obliczy, ile pieniędzy pozostało po odjęciu wydatków od początkowego budżetu.
* Podsumowanie budżetu – użytkownik będzie mógł wyświetlić budżet początkowy, sumę wydatków i pozostałą kwotę.
* Sprawdzanie poprawności danych – program nie pozwoli na dodanie wydatku z pustą nazwą lub nieprawidłową kwotą.
4. Technologie

W projekcie zostaną wykorzystane następujące technologie:

* Język programowania: C#
* Platforma: .NET
* Środowisko programistyczne: Visual Studio lub Visual Studio Code
* Interfejs użytkownika: konsola tekstowa
* Przechowywanie danych: lista obiektów w pamięci programu
* Baza danych: nie będzie wykorzystywana
* Dodatkowe biblioteki: nie będą potrzebne

Dane będą przechowywane w pamięci programu podczas jego działania. Po zamknięciu aplikacji wprowadzone dane nie będą zachowywane.

5. Plan struktury programu

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

6. Interfejs aplikacji

Aplikacja będzie posiadała prosty interfejs tekstowy wyświetlany w konsoli. Użytkownik będzie wybierał funkcje za pomocą numerów.

Przykładowy wygląd menu głównego:

================================
BUDZET OSOBISTY
===

1. Ustaw budzet
2. Dodaj wydatek
3. Wyswietl wydatki
4. Usun wydatek
5. Podsumowanie budzetu
6. Zakoncz program
Wybierz opcje:

Przykładowy wygląd listy wydatków:

========== WYDATKI ==========

1. Jedzenie - 120,00 zl
2. Transport - 80,00 zl
3. Rozrywka - 50,00 zl
Suma wydatkow: 250,00 zl
Pozostaly budzet: 750,00 zl

Po wykonaniu wybranej operacji program będzie wracał do menu głównego. Aplikacja zakończy działanie po wybraniu opcji 0.

7. Plan działania

Projekt będzie realizowany w następujących etapach:

1. Utworzenie nowego projektu konsolowego w języku C#.
2. Przygotowanie podstawowej struktury programu i menu głównego.
3. Utworzenie klasy Expense do przechowywania informacji o wydatkach.
4. Przygotowanie listy przechowującej wydatki.
5. Implementacja funkcji ustawiania budżetu.
6. Implementacja dodawania i wyświetlania wydatków.
7. Implementacja usuwania wybranego wydatku.
8. Dodanie obliczania sumy wydatków i pozostałego budżetu.
9. Dodanie sprawdzania poprawności wprowadzanych danych.
10. Przetestowanie wszystkich funkcji programu i poprawienie ewentualnych błędów.
11. Przygotowanie dokumentacji projektu w pliku README.md.

# 

# ===================================



1. #### wykonane funkcjonalności:



* Program jest konsolową listą zadań. Pozwala:
* dodawać zadania — nie przyjmuje pustej nazwy ani samych spacji;
* wyświetlać zadania wraz ze statusem „Do wykonania” lub „Wykonane”;
* oznaczać zadanie jako wykonane;
* usuwać zadanie z listy;
* kończyć działanie po wybraniu opcji 0.
* Numery zadań są widoczne na liście. Program sprawdza, czy podany numer jest poprawny, i informuje o błędnym wyborze z menu.



#### 2\. Wykorzystane technologie:



* C# i .NET 10 (net10.0);
* aplikacja konsolowa;
* standardowe biblioteki .NET: System oraz System.Collections.Generic;
* brak zewnętrznych pakietów i bazy danych



#### 3.Rzeczywista struktura programu:



Projekt/

├── Projekt.slnx

├── README.md

└── Projekt/

&#x20;   ├── Projekt.csproj

&#x20;   ├── Program.cs

&#x20;   ├── bin/       (pliki wynikowe)

&#x20;   └── obj/       (pliki generowane podczas kompilacji)



Główny kod aplikacji znajduje się w Projekt/Program.cs.

Plik Projekt.csproj określa typ aplikacji, wersję .NET i ustawienia projektu. Projekt.slnx zawiera projekt,

a README opis całego projektu.



#### 4\. Sposób uruchomienia:



W terminalu, z katalogu głównego repozytorium:



&#x09;dotnet run --project Projekt\\Projekt.csproj



Wymagany jest zainstalowany .NET 10 SDK. Projekt można również otworzyć w Visual Studio i uruchomić jako aplikację konsolową.



#### 5\. Najważniejsze elementy kodu:



•	TaskItem — reprezentuje zadanie, przechowując jego nazwę (Name) i status (IsCompleted).

•	Program.tasks — lista zadań przechowywana w pamięci.

•	Main() — wyświetla menu i kieruje wyborem użytkownika do właściwej operacji.

•	AddTask() — pobiera nazwę i dodaje nowe zadanie.

•	ShowTasks() — pokazuje listę oraz statusy.

•	CompleteTask() — oznacza wybrane zadanie jako wykonane.

•	DeleteTask() — usuwa wybrane zadanie.



#### 6\. Przechowywanie danych:



Zadania są przechowywane wyłącznie w pamięci programu, w liście List<TaskItem>. Nie są zapisywane do pliku ani bazy danych, więc po zakończeniu programu lista zostaje utracona.



#### 7\. Przykład działania:



=== LISTA ZADAN ===

1\. Dodaj zadanie

2\. Wyswietl zadania

3\. Oznacz jako wykonane

4\. Usun zadanie

0\. Zakoncz program

Wybierz opcje: 1

Podaj nazwe zadania: Zrobic zakupy

Dodano zadanie.



Wybierz opcje: 2



Twoje zadania:

1\. Zrobic zakupy - Do wykonania



Wybierz opcje: 3

Twoje zadania:

1\. Zrobic zakupy - Do wykonania

Podaj numer zadania: 1

Oznaczono zadanie jako wykonane.



Wybierz opcje: 2



Twoje zadania:

1\. Zrobic zakupy - Wykonane



# ================



## Zmiany wzgledęm pierwotnej wersji:



* #### Nazwa



&#x09;Budżet osobisty -> Projekt



* #### Cel



&#x09;Kontrolowanie budżetu i wydatków => Zarządzanie listą zadań



* #### Funkcje



&#x09;Ustawianie budżetu, dodawanie i usuwanie wydatków, obliczanie sumy i pozostałej kwoty, podsumowanie -> 	Dodawanie, wyświetlanie, oznaczanie jako wykonane i usuwanie zadań



* #### Dane



&#x09;Obiekt Expense z nazwą i kwotą -> Obiekt TaskItem z nazwą i statusem wykonania



* #### Menu



&#x09;Opcje związane z budżetem i wydatkami -> Opcje związane z zadaniami



* #### Struktura



&#x09;Planowane BudzetOsobisty/Program.cs i BudzetOsobisty.csproj -> Projekt/Program.cs i Projekt/Projekt.csproj, rozwiązanie Projekt.slnx



* #### Najważniejsza rozbieżność

&#x09;

Funkcje budżetowe z README nie są zaimplementowane: w programie nie ma ustawiania budżetu, kwot wydatków, sumowania wydatków ani obliczania pozostałych pieniędzy. Zamiast tego program obsługuje zadania i ich status.



Różnią się także nazwy projektu i elementów kodu: README planuje Expense, AddExpense() i ShowSummary(), a kod zawiera TaskItem, AddTask() i ShowTasks().


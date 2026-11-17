
using System;
using System.Collections.Generic;

// Reprezentuje pojedyncze zadanie na liście.
class TaskItem
{
    // Przechowuje nazwę zadania.
    public string Name { get; set; }

    // Informuje, czy zadanie zostało już wykonane.
    public bool IsCompleted { get; set; }

    // Tworzy nowe zadanie i ustawia je jako niewykonane.
    public TaskItem(string name)
    {
        Name = name;
        IsCompleted = false;
    }
}

class Program
{
    // Lista wszystkich zadań przechowywanych w pamięci programu.
    static List<TaskItem> tasks = new List<TaskItem>();

    // Główna metoda programu, od której rozpoczyna się jego działanie.
    static void Main()
    {
        // Określa, czy główna pętla programu ma nadal działać.
        bool running = true;

        // Wyświetla menu i obsługuje wybory użytkownika do momentu zakończenia programu.
        while (running)
        {
            Console.WriteLine("\n=== LISTA ZADAN ===");
            Console.WriteLine("1. Dodaj zadanie");
            Console.WriteLine("2. Wyswietl zadania");
            Console.WriteLine("3. Oznacz jako wykonane");
            Console.WriteLine("4. Usun zadanie");
            Console.WriteLine("0. Zakoncz program");
            Console.Write("Wybierz opcje: ");

            // Odczytuje wybór użytkownika; pusty tekst zastępuje ewentualną wartość null.
            string choice = Console.ReadLine() ?? "";

            // Uruchamia odpowiednią funkcję zależnie od wybranej opcji. ;)
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;

                case "2":
                    ShowTasks();
                    break;

                case "3":
                    CompleteTask();
                    break;

                case "4":
                    DeleteTask();
                    break;

                case "0":
                    // Ustawienie false kończy działanie głównej pętli.
                    running = false;
                    Console.WriteLine("Koniec programu.");
                    break;

                default:
                    Console.WriteLine("Nieprawidlowa opcja!");
                    break;
            }
        }
    }

    // Pobiera nazwę i dodaje nowe zadanie do listy.
    static void AddTask()
    {
        Console.Write("Podaj nazwe zadania: ");
        string name = Console.ReadLine() ?? "";

        // Nie pozwala dodać zadania bez nazwy lub zawierającego wyłącznie spacje.
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Nazwa zadania nie moze byc pusta.");
            return;
        }

        // Tworzy zadanie i dodaje je do listy.
        tasks.Add(new TaskItem(name));
        Console.WriteLine("Dodano zadanie.");
    }

    // Wyświetla wszystkie zadania wraz z ich aktualnym statusem.
    static void ShowTasks()
    {
        // Kończy metodę, jeśli lista zadań jest pusta.
        if (tasks.Count == 0)
        {
            Console.WriteLine("Brak zadan.");
            return;
        }

        Console.WriteLine("\nTwoje zadania:");

        // Przechodzi po wszystkich zadaniach i wyświetla je po kolei.
        for (int i = 0; i < tasks.Count; i++)
        {
            // Ustala tekst statusu na podstawie wartości IsCompleted.
            string status = tasks[i].IsCompleted
                ? "Wykonane"
                : "Do wykonania";

            Console.WriteLine(
                $"{i + 1}. {tasks[i].Name} - {status}"
            );
        }
    }

    // Oznacza wybrane zadanie jako wykonane.
    static void CompleteTask()
    {
        // Pokazuje zadania, aby użytkownik mógł wybrać ich numer.
        ShowTasks();

        // Nie kontynuuje działania, jeśli nie ma żadnych zadań.
        if (tasks.Count == 0)
            return;

        Console.Write("Podaj numer zadania: ");

        // Sprawdza, czy podano prawidłowy numer istniejącego zadania.
        if (int.TryParse(Console.ReadLine(), out int number)
            && number >= 1
            && number <= tasks.Count)
        {
            // Indeks listy zaczyna się od zera, dlatego od numeru odejmujemy jeden.
            tasks[number - 1].IsCompleted = true;
            Console.WriteLine("Oznaczono zadanie jako wykonane.");
        }
        else
        {
            Console.WriteLine("Nieprawidlowy numer zadania.");
        }
    }

    // Usuwa wybrane zadanie z listy.
    static void DeleteTask()
    {
        // Pokazuje zadania, aby użytkownik mógł wybrać zadanie do usunięcia.
        ShowTasks();

        // Nie kontynuuje działania, jeśli lista jest pusta.
        if (tasks.Count == 0)
            return;

        Console.Write("Podaj numer zadania do usuniecia: ");

        // Sprawdza, czy podano prawidłowy numer istniejącego zadania.
        if (int.TryParse(Console.ReadLine(), out int number)
            && number >= 1
            && number <= tasks.Count)
        {
            // Usuwa zadanie z listy; numer użytkownika zamieniamy na indeks listy.
            tasks.RemoveAt(number - 1);
            Console.WriteLine("Usunieto zadanie.");
        }
        else
        {
            Console.WriteLine("Nieprawidlowy numer zadania.");
        }
    }
}
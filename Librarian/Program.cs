using System.Collections.Concurrent;

namespace Librarian
{
    internal class Program
    {
        static ConcurrentDictionary<string, int> _books = new();
        static void Main(string[] args)
        {
            Task.Run(() => UpdateRead());
            while (true)
            {
                ShowMenu();
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    AddBook();
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    PrintUnreadBooks();
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Good Bye");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }

        private static void UpdateRead()
        {
            while (true)
            {
                Thread.Sleep(1000);
                _books.ToList().ForEach(b =>
                {
                    _books[b.Key] = b.Value + 1;
                    if (b.Value >= 100)
                    {
                        _books.TryRemove(b.Key, out _);
                    }
                }

                );
            }
        }

        private static void PrintUnreadBooks()
        {
            Console.Clear();
            Console.WriteLine("Your unread books:");
            _books.ToList().ForEach(b => Console.WriteLine($"{b.Key} - {b.Value}"));
            Console.WriteLine("Press any key to menu");
            Console.ReadKey();
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Show unread");
            Console.WriteLine("3. Exit");
        }

        static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("Please enter name your book");
            var bookName = Console.ReadLine();
            if (!string.IsNullOrEmpty(bookName))
            {
                _books.TryAdd(bookName, 0);
            }
        }
    }
}

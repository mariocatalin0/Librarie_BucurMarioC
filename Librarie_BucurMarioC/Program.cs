using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the library
ILibrary library = (ILibrary)new Library("Library App Co.");

            // Add some sample books
            library.AddBook(new Book("Harry Potter And The Goblet Of Fire", "J.K. Rowling", "Fantasy", 2000, 636));
            library.AddBook(new Book("Harry Potter And The Prisoner of Azkaban", "J.K. Rowling", "Fantasy", 1999, 435));
            library.AddBook(new Book("Harry Potter And The Chamber of Secrets", "J.K. Rowling", "Fantasy", 1998, 341));
            library.AddBook(new Book("The Lord of the Rings", "J.R.R. Tolkien", "Fantasy", 1954, 1178));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "Classic", 1960, 281));
            library.AddBook(new Book("1984", "George Orwell", "Dystopian", 1949, 328));
            library.AddBook(new Book("Pride and Prejudice", "Jane Austen", "Romance", 1813, 432));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 1925, 180));

            // Add some sample clients
            library.AddClient(new Client("Bucur Raisa Elena", "raisa.bucur@gmail.com", "074-546-013"));
            library.AddClient(new Client("Rebeca Dragoi", "rebeca.dragoi@gmail.com", "074-546-783"));
            library.AddClient(new Client("Robert Maxim", "robert.maxim@gmail.com", "074-389-023"));

            bool running = true;
            while (running)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayWelcomeScreen(library.Name);
                        break;
                    case "2":
                        DisplayCommunityScreen();
                        break;
                    case "3":
                        DisplayRecommendationScreen(library);
                        break;
                    case "4":
                        DisplayAllBooks(library);
                        break;
                    case "5":
                        ManageClients(library);
                        break;
                    case "6":
                        BorrowBook(library);
                        break;
                    case "7":
                        ReturnBook(library);
                        break;
                    case "8":
                        running = false;
                        Console.WriteLine("Vă mulțumim că ați utilizat Sistemul de Gestionare a Bibliotecii. La revedere!");
                        break;
                    default:
                        Console.WriteLine("Opțiune invalidă. Vă rugăm să încercați din nou.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nApăsați orice tastă pentru a continua...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void DisplayMainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║     SISTEM DE GESTIONARE A BIBLIOTECII    ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("\nVă rugăm să selectați o opțiune:\n");
            Console.WriteLine("1. Ecran de Bun Venit");
            Console.WriteLine("2. Ecran Comunitate");
            Console.WriteLine("3. Recomandări");
            Console.WriteLine("4. Vizualizare Toate Cărțile");
            Console.WriteLine("5. Gestionare Clienți");
            Console.WriteLine("6. Împrumută o Carte");
            Console.WriteLine("7. Returnează o Carte");
            Console.WriteLine("8. Ieșire");
            Console.Write("\nIntroduceți alegerea dvs. (1-8): ");
        }

        static void DisplayWelcomeScreen(string libraryName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║            CARTEA LUMII             ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n  Pregătiți-vă să Începeți un Nou");
            Console.WriteLine("  Capitol de Explorare,");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  Lectură Plăcută!");
            Console.ResetColor();

            Console.WriteLine("\n  Bun venit la " + libraryName);
            Console.WriteLine("  Poarta dvs. către cunoaștere și aventură.");

            Console.WriteLine("\n  [←] Înapoi | [→] Înainte");
        }

        static void DisplayCommunityScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║          CENTRU COMUNITAR           ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  Comunitate și Discuții,");
            Console.WriteLine("  Conectați-vă cu Alți Iubitori");
            Console.WriteLine("  de Cărți Aici.");
            Console.ResetColor();

            Console.WriteLine("\n  • Alăturați-vă grupurilor de lectură");
            Console.WriteLine("  • Discutați despre cărțile dvs. preferate");
            Console.WriteLine("  • Împărtășiți recomandări");
            Console.WriteLine("  • Participați la evenimente");

            Console.WriteLine("\n  [→] Începeți");
        }

        static void DisplayRecommendationScreen(ILibrary library)
        {
            Console.Clear();
            Console.WriteLine($"  {DateTime.Now.ToString("d MMM yy")}");
            Console.WriteLine($"  {library.Name}\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  Recomandare                Categorii");
            Console.ResetColor();

            // Display a featured book
            IBook featuredBook = library.GetBooks().FirstOrDefault(b => b.Title.Contains("Harry Potter"));
            if (featuredBook != null)
            {
                Console.WriteLine("\n  Cartea Recomandată:");
                Console.WriteLine($"  {featuredBook.Title}");
                Console.WriteLine($"  de {featuredBook.Author}\n");
            }

            Console.WriteLine("  Toate Cărțile                      Arată Mai Multe");

            // Display some books
            var books = library.GetBooks().Take(3).ToList();
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {books[i].Title} ({books[i].Pages} pagini)");
            }

            Console.WriteLine("\n  [Acasă] [Cărți] [Comunitate] [Profil]");
        }

        static void DisplayAllBooks(ILibrary library)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║         TOATE CĂRȚILE               ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();

            var books = library.GetBooks();
            if (books.Count == 0)
            {
                Console.WriteLine("\nNu există cărți în bibliotecă.");
                return;
            }

            Console.WriteLine("\nLista tuturor cărților:\n");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }

        static void ManageClients(ILibrary library)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║         GESTIONARE CLIENȚI          ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();

            var clients = library.GetClients();
            if (clients.Count == 0)
            {
                Console.WriteLine("\nNu există clienți înregistrați.");
                return;
            }

            Console.WriteLine("\nLista clienților:\n");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clients[i].Name} - {clients[i].Email} - {clients[i].Phone}");
                
                var borrowedBooks = clients[i].GetBorrowedBooks();
                if (borrowedBooks.Count > 0)
                {
                    Console.WriteLine("   Cărți împrumutate:");
                    foreach (var book in borrowedBooks)
                    {
                        Console.WriteLine($"   - {book.Title} de {book.Author}");
                    }
                }
                Console.WriteLine();
            }
        }

        static void BorrowBook(ILibrary library)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║         ÎMPRUMUTĂ O CARTE           ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();

            // Get available books
            var availableBooks = library.GetBooks().Where(b => !library.GetClients().Any(c => c.GetBorrowedBooks().Contains(b))).ToList();
            if (availableBooks.Count == 0)
            {
                Console.WriteLine("\nNu există cărți disponibile pentru împrumut.");
                return;
            }

            // Get clients
            var clients = library.GetClients();
            if (clients.Count == 0)
            {
                Console.WriteLine("\nNu există clienți înregistrați.");
                return;
            }

            // Display available books
            Console.WriteLine("\nCărți disponibile pentru împrumut:\n");
            for (int i = 0; i < availableBooks.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {availableBooks[i].Title} de {availableBooks[i].Author}");
            }

            // Select a book
            Console.Write("\nAlegeți numărul cărții pentru împrumut (0 pentru anulare): ");
            if (!int.TryParse(Console.ReadLine(), out int bookIndex) || bookIndex < 1 || bookIndex > availableBooks.Count())
            {
                if (bookIndex == 0)
                {
                    Console.WriteLine("Operațiune anulată.");
                }
                else
                {
                    Console.WriteLine("Selecție invalidă.");
                }
                return;
            }

            // Display clients
            Console.WriteLine("\nClienți:\n");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clients[i].Name}");
            }

            // Select a client
            Console.Write("\nAlegeți numărul clientului (0 pentru anulare): ");
            if (!int.TryParse(Console.ReadLine(), out int clientIndex) || clientIndex < 1 || clientIndex > clients.Count)
            {
                if (clientIndex == 0)
                {
                    Console.WriteLine("Operațiune anulată.");
                }
                else
                {
                    Console.WriteLine("Selecție invalidă.");
                }
                return;
            }

            // Borrow the book
            IBook selectedBook = availableBooks[bookIndex - 1];
            IClient selectedClient = clients[clientIndex - 1];

            selectedClient.BorrowBook(selectedBook);
            Console.WriteLine($"\nCartea '{selectedBook.Title}' a fost împrumutată cu succes de către {selectedClient.Name}.");
        }

        static void ReturnBook(ILibrary library)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║         RETURNEAZĂ O CARTE          ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();

            // Get clients
            var clients = library.GetClients();
            if (clients.Count == 0)
            {
                Console.WriteLine("\nNu există clienți înregistrați.");
                return;
            }

            // Display clients
            Console.WriteLine("\nClienți:\n");
            List<IClient> clientsWithBooks = new List<IClient>();
            for (int i = 0; i < clients.Count; i++)
            {
                var borrowedBooks = clients[i].GetBorrowedBooks();
                if (borrowedBooks.Count > 0)
                {
                    clientsWithBooks.Add(clients[i]);
                    Console.WriteLine($"{clientsWithBooks.Count}. {clients[i].Name}");
                }
            }

            if (clientsWithBooks.Count == 0)
            {
                Console.WriteLine("\nNiciun client nu are cărți împrumutate.");
                return;
            }

            // Select a client
            Console.Write("\nAlegeți numărul clientului (0 pentru anulare): ");
            if (!int.TryParse(Console.ReadLine(), out int clientIndex) || clientIndex < 1 || clientIndex > clientsWithBooks.Count)
            {
                if (clientIndex == 0)
                {
                    Console.WriteLine("Operațiune anulată.");
                }
                else
                {
                    Console.WriteLine("Selecție invalidă.");
                }
                return;
            }

            // Display borrowed books
            IClient selectedClient = clientsWithBooks[clientIndex - 1];
            var clientBooks = selectedClient.GetBorrowedBooks();

            Console.WriteLine($"\nCărți împrumutate de {selectedClient.Name}:\n");
            for (int i = 0; i < clientBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientBooks[i].Title} de {clientBooks[i].Author}");
            }

            // Select a book
            Console.Write("\nAlegeți numărul cărții pentru returnare (0 pentru anulare): ");
            if (!int.TryParse(Console.ReadLine(), out int bookIndex) || bookIndex < 1 || bookIndex > clientBooks.Count)
            {
                if (bookIndex == 0)
                {
                    Console.WriteLine("Operațiune anulată.");
                }
                else
                {
                    Console.WriteLine("Selecție invalidă.");
                }
                return;
            }

            // Return the book
            IBook selectedBook = clientBooks[bookIndex - 1];
            selectedClient.ReturnBook(selectedBook);
            Console.WriteLine($"\nCartea '{selectedBook.Title}' a fost returnată cu succes de către {selectedClient.Name}.");
        }
    }
}
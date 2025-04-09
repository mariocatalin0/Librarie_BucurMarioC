using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace LibraryManagementSystem
{
    public class Library
    {
        public string Name { get; private set; }
        private List<Book> books;
        private List<Client> clients;
        private const string ClientsFilePath = "clients.json";
        private const string BooksFilePath = "books.json";

        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
            clients = new List<Client>();
            LoadBooks(); // Load books first
            LoadClients(); // Then load clients to properly restore borrowed books
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            SaveBooks(); // Save books after adding a new one
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            SaveBooks(); // Save books after removing one
        }

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
            SaveClients(); // Save clients after adding a new one
        }

        public void RemoveClient(Client client)
        {
            clients.Remove(client);
            SaveClients(); // Save clients after removing one
        }

        public List<Client> GetClients()
        {
            return new List<Client>(clients);
        }

        // Save clients to JSON file
        private void SaveClients()
        {
            try
            {
                // Create a list of serializable client data
                var clientDataList = new List<ClientData>();
                foreach (var client in clients)
                {
                    var clientData = new ClientData
                    {
                        Name = client.Name,
                        Email = client.Email,
                        Phone = client.Phone,
                        BorrowedBookTitles = new List<string>()
                    };

                    // Add borrowed book titles
                    foreach (var book in client.GetBorrowedBooks())
                    {
                        clientData.BorrowedBookTitles.Add(book.Title);
                    }

                    clientDataList.Add(clientData);
                }

                // Serialize to JSON
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(clientDataList, options);

                // Write to file
                File.WriteAllText(ClientsFilePath, jsonString);
                Console.WriteLine("Clienții au fost salvați cu succes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la salvarea clienților: {ex.Message}");
            }
        }

        // Load clients from JSON file
        private void LoadClients()
        {
            try
            {
                if (File.Exists(ClientsFilePath))
                {
                    string jsonString = File.ReadAllText(ClientsFilePath);
                    var clientDataList = JsonSerializer.Deserialize<List<ClientData>>(jsonString);

                    if (clientDataList != null)
                    {
                        foreach (var clientData in clientDataList)
                        {
                            // Create new client from saved data
                            var client = new Client(clientData.Name, clientData.Email, clientData.Phone);
                            clients.Add(client);

                            // Restore borrowed books
                            if (clientData.BorrowedBookTitles != null && clientData.BorrowedBookTitles.Count > 0)
                            {
                                foreach (var bookTitle in clientData.BorrowedBookTitles)
                                {
                                    // Find the book by title
                                    var book = books.Find(b => b.Title == bookTitle);
                                    if (book != null)
                                    {
                                        client.BorrowBook(book);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Clienții au fost încărcați cu succes.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la încărcarea clienților: {ex.Message}");
            }
        }

        // Save books to JSON file
        private void SaveBooks()
        {
            try
            {
                // Create a list of serializable book data
                var bookDataList = new List<BookData>();
                foreach (var book in books)
                {
                    bookDataList.Add(new BookData
                    {
                        Title = book.Title,
                        Author = book.Author,
                        Genre = book.Genre,
                        Year = book.Year,
                        Pages = book.Pages,
                        IsAvailable = book.IsAvailable
                    });
                }

                // Serialize to JSON
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(bookDataList, options);

                // Write to file
                File.WriteAllText(BooksFilePath, jsonString);
                Console.WriteLine("Cărțile au fost salvate cu succes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la salvarea cărților: {ex.Message}");
            }
        }

        // Load books from JSON file
        private void LoadBooks()
        {
            try
            {
                if (File.Exists(BooksFilePath))
                {
                    string jsonString = File.ReadAllText(BooksFilePath);
                    var bookDataList = JsonSerializer.Deserialize<List<BookData>>(jsonString);

                    if (bookDataList != null)
                    {
                        foreach (var bookData in bookDataList)
                        {
                            // Create new book from saved data
                            var book = new Book(bookData.Title, bookData.Author, bookData.Genre, bookData.Year, bookData.Pages);
                            if (!bookData.IsAvailable)
                            {
                                book.MarkAsBorrowed();
                            }
                            books.Add(book);
                        }
                        Console.WriteLine("Cărțile au fost încărcate cu succes.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la încărcarea cărților: {ex.Message}");
            }
        }

        public List<IBook> SearchBooksByTitle(string title)
        {
            return books.FindAll(b => b.Title.ToLower().Contains(title.ToLower())).ConvertAll(book => (IBook)book);
        }

        public List<IBook> SearchBooksByAuthor(string author)
        {
            return books.FindAll(b => b.Author.ToLower().Contains(author.ToLower())).ConvertAll(book => (IBook)book);
        }

        public List<IBook> SearchBooksByGenre(string genre)
        {
            return books.FindAll(b => b.Genre.ToLower().Contains(genre.ToLower())).ConvertAll(book => (IBook)book);
        }

        public List<IBook> GetAvailableBooks()
        {
            return books.FindAll(b => b.IsAvailable).ConvertAll(book => (IBook)book);
        }
    }

    // Helper class for serialization
    class ClientData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<string> BorrowedBookTitles { get; set; } = new List<string>();
    }

    // Helper class for book serialization
    class BookData
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }
    }
}
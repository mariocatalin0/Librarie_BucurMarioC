using System;
using System.Collections.Generic;

namespace Interfata
{
    public interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string Genre { get; set; }
        int Year { get; set; }
        int Pages { get; set; }
        bool IsAvailable { get; set; }
    }

    public interface IClient
    {
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        List<IBook> BorrowedBooks { get; }
        void BorrowBook(IBook book);
        void ReturnBook(IBook book);
    }

    public interface ILibrary
    {
        List<IBook> Books { get; }
        List<IClient> Clients { get; }
        void AddBook(IBook book);
        void AddClient(IClient client);
        void RemoveBook(IBook book);
        void RemoveClient(IClient client);
        bool LendBook(IBook book, IClient client);
        bool ReturnBook(IBook book, IClient client);
    }
}
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        string Genre { get; }
        int Year { get; }
        int Pages { get; }
        bool IsAvailable { get; }
        void MarkAsBorrowed();
        void MarkAsReturned();
    }

    public interface IClient
    {
        string Name { get; }
        string Email { get; }
        string Phone { get; }
        void BorrowBook(IBook book);
        void ReturnBook(IBook book);
        List<IBook> GetBorrowedBooks();
    }

    public interface ILibrary
    {
        string Name { get; }
        void AddBook(IBook book);
        void RemoveBook(IBook book);
        List<IBook> GetBooks();
        void AddClient(IClient client);
        void RemoveClient(IClient client);
        List<IClient> GetClients();
    }
}
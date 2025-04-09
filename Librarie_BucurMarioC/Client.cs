using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Client : IClient
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        private List<IBook> borrowedBooks;

        public Client(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            borrowedBooks = new List<IBook>();
        }

        public Client(string name)
        {
            Name = name;
            Email = "";
            Phone = "";
            borrowedBooks = new List<IBook>();
        }

        public void BorrowBook(IBook book)
        {
            if (book.IsAvailable)
            {
                borrowedBooks.Add(book);
                book.MarkAsBorrowed();
            }
        }

        public void ReturnBook(IBook book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                book.MarkAsReturned();
            }
        }

        public List<IBook> GetBorrowedBooks()
        {
            return new List<IBook>(borrowedBooks);
        }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone} - Cărți împrumutate: {borrowedBooks.Count}";
        }
    }
}
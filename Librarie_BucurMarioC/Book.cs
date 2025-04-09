using System;

namespace LibraryManagementSystem
{
    
    public class Book : IBook
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }
        public int Pages { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string author, string genre, int year, int pages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Pages = pages;
            IsAvailable = true;
        }

        public void MarkAsBorrowed()
        {
            IsAvailable = false;
        }

        public void MarkAsReturned()
        {
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"{Title} de {Author} ({Year}) - {Genre} - {Pages} pagini - {(IsAvailable ? "Disponibil" : "Împrumutat")}";
        }
    }
}
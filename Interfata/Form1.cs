using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem;

namespace Interfata
{
    public partial class Form1 : Form
    {
        private Library library;
        private Book selectedBook;
        private Client selectedClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inițializare bibliotecă
            library = new Library("Biblioteca Municipală");

            // Încărcare date inițiale (dacă nu există deja în fișierele JSON)
            if (library.GetBooks().Count == 0)
            {
                // Adăugare cărți de exemplu
                library.AddBook(new Book("Amintiri din copilărie", "Ion Creangă", "Literatură română", 1892, 200));
                library.AddBook(new Book("Moara cu noroc", "Ioan Slavici", "Nuvelă", 1881, 150));
                library.AddBook(new Book("Baltagul", "Mihail Sadoveanu", "Roman", 1930, 250));
                library.AddBook(new Book("Ion", "Liviu Rebreanu", "Roman", 1920, 400));
                library.AddBook(new Book("Enigma Otiliei", "George Călinescu", "Roman", 1938, 350));
            }

            if (library.GetClients().Count == 0)
            {
                // Adăugare clienți de exemplu
                library.AddClient(new Client("Popescu Ion", "popescu.ion@email.com", "0722123456"));
                library.AddClient(new Client("Ionescu Maria", "maria.ionescu@email.com", "0733123456"));
                library.AddClient(new Client("Georgescu Andrei", "andrei.g@email.com", "0744123456"));
            }

            // Actualizare interfață
            RefreshBooksList();
            RefreshClientsList();
        }

        private void RefreshBooksList()
        {
            booksListBox.Items.Clear();
            foreach (var book in library.GetBooks())
            {
                booksListBox.Items.Add(book);
            }
        }

        private void RefreshClientsList()
        {
            clientsListBox.Items.Clear();
            foreach (var client in library.GetClients())
            {
                clientsListBox.Items.Add(client);
            }
        }

        private void RefreshBorrowedBooksList()
        {
            borrowedBooksListBox.Items.Clear();
            if (selectedClient != null)
            {
                foreach (var book in selectedClient.GetBorrowedBooks())
                {
                    borrowedBooksListBox.Items.Add(book);
                }
            }
        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedItem != null)
            {
                selectedBook = (Book)booksListBox.SelectedItem;
                bookTitleTextBox.Text = selectedBook.Title;
                bookAuthorTextBox.Text = selectedBook.Author;
                bookGenreTextBox.Text = selectedBook.Genre;
                bookYearTextBox.Text = selectedBook.Year.ToString();
                bookPagesTextBox.Text = selectedBook.Pages.ToString();
                bookStatusLabel.Text = selectedBook.IsAvailable ? "Disponibil" : "Împrumutat";
                bookStatusLabel.ForeColor = selectedBook.IsAvailable ? Color.Green : Color.Red;
            }
        }

        private void clientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientsListBox.SelectedItem != null)
            {
                selectedClient = (Client)clientsListBox.SelectedItem;
                clientNameTextBox.Text = selectedClient.Name;
                clientEmailTextBox.Text = selectedClient.Email;
                clientPhoneTextBox.Text = selectedClient.Phone;
                RefreshBorrowedBooksList();
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = bookTitleTextBox.Text.Trim();
                string author = bookAuthorTextBox.Text.Trim();
                string genre = bookGenreTextBox.Text.Trim();
                int year = int.Parse(bookYearTextBox.Text.Trim());
                int pages = int.Parse(bookPagesTextBox.Text.Trim());

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                    MessageBox.Show("Titlul și autorul sunt obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Book newBook = new Book(title, author, genre, year, pages);
                library.AddBook(newBook);
                RefreshBooksList();
                ClearBookFields();
                MessageBox.Show("Cartea a fost adăugată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la adăugarea cărții: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBookFields()
        {
            bookTitleTextBox.Text = "";
            bookAuthorTextBox.Text = "";
            bookGenreTextBox.Text = "";
            bookYearTextBox.Text = "";
            bookPagesTextBox.Text = "";
            bookStatusLabel.Text = "Disponibil";
            bookStatusLabel.ForeColor = Color.Green;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = clientNameTextBox.Text.Trim();
                string email = clientEmailTextBox.Text.Trim();
                string phone = clientPhoneTextBox.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Numele clientului este obligatoriu!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Client newClient = new Client(name, email, phone);
                library.AddClient(newClient);
                RefreshClientsList();
                ClearClientFields();
                MessageBox.Show("Clientul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la adăugarea clientului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearClientFields()
        {
            clientNameTextBox.Text = "";
            clientEmailTextBox.Text = "";
            clientPhoneTextBox.Text = "";
            borrowedBooksListBox.Items.Clear();
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Selectați un client pentru a împrumuta o carte!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Afișare dialog pentru selectarea cărții
            Form borrowForm = new Form();
            borrowForm.Text = "Selectați cartea pentru împrumut";
            borrowForm.Size = new Size(400, 400);
            borrowForm.StartPosition = FormStartPosition.CenterParent;

            ListBox availableBooksListBox = new ListBox();
            availableBooksListBox.Dock = DockStyle.Fill;
            availableBooksListBox.DisplayMember = "Title";

            // Adăugare doar cărți disponibile
            foreach (var book in library.GetBooks())
            {
                if (book.IsAvailable)
                {
                    availableBooksListBox.Items.Add(book);
                }
            }

            Button selectButton = new Button();
            selectButton.Text = "Împrumută";
            selectButton.Dock = DockStyle.Bottom;
            selectButton.Click += (s, args) =>
            {
                if (availableBooksListBox.SelectedItem != null)
                {
                    IBook bookToBorrow = (IBook)availableBooksListBox.SelectedItem;
                    selectedClient.BorrowBook(bookToBorrow);
                    RefreshBorrowedBooksList();
                    RefreshBooksList();
                    borrowForm.Close();
                    MessageBox.Show("Cartea a fost împrumutată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selectați o carte pentru împrumut!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            borrowForm.Controls.Add(availableBooksListBox);
            borrowForm.Controls.Add(selectButton);
            borrowForm.ShowDialog();
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Selectați un client pentru a returna o carte!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (borrowedBooksListBox.SelectedItem == null)
            {
                MessageBox.Show("Selectați o carte pentru returnare!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IBook bookToReturn = (IBook)borrowedBooksListBox.SelectedItem;
            selectedClient.ReturnBook(bookToReturn);
            RefreshBorrowedBooksList();
            RefreshBooksList();
            MessageBox.Show("Cartea a fost returnată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

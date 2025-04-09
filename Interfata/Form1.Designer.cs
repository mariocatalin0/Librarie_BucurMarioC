namespace Interfata
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.bookDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.bookStatusLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.bookPagesTextBox = new System.Windows.Forms.TextBox();
            this.bookYearTextBox = new System.Windows.Forms.TextBox();
            this.bookGenreTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.clientsTab = new System.Windows.Forms.TabPage();
            this.borrowedBooksGroupBox = new System.Windows.Forms.GroupBox();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.borrowedBooksListBox = new System.Windows.Forms.ListBox();
            this.clientDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.borrowBookButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.clientPhoneTextBox = new System.Windows.Forms.TextBox();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.bookDetailsGroupBox.SuspendLayout();
            this.clientsTab.SuspendLayout();
            this.borrowedBooksGroupBox.SuspendLayout();
            this.clientDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.clientsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.bookDetailsGroupBox);
            this.booksTab.Controls.Add(this.booksListBox);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(976, 535);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Cărți";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // bookDetailsGroupBox
            // 
            this.bookDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDetailsGroupBox.Controls.Add(this.bookStatusLabel);
            this.bookDetailsGroupBox.Controls.Add(this.label10);
            this.bookDetailsGroupBox.Controls.Add(this.addBookButton);
            this.bookDetailsGroupBox.Controls.Add(this.bookPagesTextBox);
            this.bookDetailsGroupBox.Controls.Add(this.bookYearTextBox);
            this.bookDetailsGroupBox.Controls.Add(this.bookGenreTextBox);
            this.bookDetailsGroupBox.Controls.Add(this.bookAuthorTextBox);
            this.bookDetailsGroupBox.Controls.Add(this.bookTitleTextBox);
            this.bookDetailsGroupBox.Controls.Add(this.label5);
            this.bookDetailsGroupBox.Controls.Add(this.label4);
            this.bookDetailsGroupBox.Controls.Add(this.label3);
            this.bookDetailsGroupBox.Controls.Add(this.label2);
            this.bookDetailsGroupBox.Controls.Add(this.label1);
            this.bookDetailsGroupBox.Location = new System.Drawing.Point(329, 6);
            this.bookDetailsGroupBox.Name = "bookDetailsGroupBox";
            this.bookDetailsGroupBox.Size = new System.Drawing.Size(641, 523);
            this.bookDetailsGroupBox.TabIndex = 1;
            this.bookDetailsGroupBox.TabStop = false;
            this.bookDetailsGroupBox.Text = "Detalii carte";
            // 
            // bookStatusLabel
            // 
            this.bookStatusLabel.AutoSize = true;
            this.bookStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookStatusLabel.Location = new System.Drawing.Point(103, 208);
            this.bookStatusLabel.Name = "bookStatusLabel";
            this.bookStatusLabel.Size = new System.Drawing.Size(78, 16);
            this.bookStatusLabel.TabIndex = 12;
            this.bookStatusLabel.Text = "Disponibil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Status";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(25, 245);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(156, 23);
            this.addBookButton.TabIndex = 10;
            this.addBookButton.Text = "Adaugă carte";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // bookPagesTextBox
            // 
            this.bookPagesTextBox.Location = new System.Drawing.Point(103, 169);
            this.bookPagesTextBox.Name = "bookPagesTextBox";
            this.bookPagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookPagesTextBox.TabIndex = 9;
            // 
            // bookYearTextBox
            // 
            this.bookYearTextBox.Location = new System.Drawing.Point(103, 134);
            this.bookYearTextBox.Name = "bookYearTextBox";
            this.bookYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookYearTextBox.TabIndex = 8;
            // 
            // bookGenreTextBox
            // 
            this.bookGenreTextBox.Location = new System.Drawing.Point(103, 99);
            this.bookGenreTextBox.Name = "bookGenreTextBox";
            this.bookGenreTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookGenreTextBox.TabIndex = 7;
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Location = new System.Drawing.Point(103, 64);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookAuthorTextBox.TabIndex = 6;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(103, 29);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(300, 20);
            this.bookTitleTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pagini";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "An";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu";
            // 
            // booksListBox
            // 
            this.booksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(8, 6);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(315, 524);
            this.booksListBox.TabIndex = 0;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            // 
            // clientsTab
            // 
            this.clientsTab.Controls.Add(this.borrowedBooksGroupBox);
            this.clientsTab.Controls.Add(this.clientDetailsGroupBox);
            this.clientsTab.Controls.Add(this.clientsListBox);
            this.clientsTab.Location = new System.Drawing.Point(4, 22);
            this.clientsTab.Name = "clientsTab";
            this.clientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTab.Size = new System.Drawing.Size(976, 535);
            this.clientsTab.TabIndex = 1;
            this.clientsTab.Text = "Clienți";
            this.clientsTab.UseVisualStyleBackColor = true;
            // 
            // borrowedBooksGroupBox
            // 
            this.borrowedBooksGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowedBooksGroupBox.Controls.Add(this.returnBookButton);
            this.borrowedBooksGroupBox.Controls.Add(this.borrowedBooksListBox);
            this.borrowedBooksGroupBox.Location = new System.Drawing.Point(649, 6);
            this.borrowedBooksGroupBox.Name = "borrowedBooksGroupBox";
            this.borrowedBooksGroupBox.Size = new System.Drawing.Size(321, 523);
            this.borrowedBooksGroupBox.TabIndex = 2;
            this.borrowedBooksGroupBox.TabStop = false;
            this.borrowedBooksGroupBox.Text = "Cărți împrumutate";
            // 
            // returnBookButton
            // 
            this.returnBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnBookButton.Location = new System.Drawing.Point(6, 494);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(156, 23);
            this.returnBookButton.TabIndex = 1;
            this.returnBookButton.Text = "Returnează carte";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // borrowedBooksListBox
            // 
            this.borrowedBooksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowedBooksListBox.FormattingEnabled = true;
            this.borrowedBooksListBox.Location = new System.Drawing.Point(6, 19);
            this.borrowedBooksListBox.Name = "borrowedBooksListBox";
            this.borrowedBooksListBox.Size = new System.Drawing.Size(309, 459);
            this.borrowedBooksListBox.TabIndex = 0;
            // 
            // clientDetailsGroupBox
            // 
            this.clientDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientDetailsGroupBox.Controls.Add(this.borrowBookButton);
            this.clientDetailsGroupBox.Controls.Add(this.addClientButton);
            this.clientDetailsGroupBox.Controls.Add(this.clientPhoneTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientEmailTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientNameTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.label8);
            this.clientDetailsGroupBox.Controls.Add(this.label7);
            this.clientDetailsGroupBox.Controls.Add(this.label6);
            this.clientDetailsGroupBox.Location = new System.Drawing.Point(329, 6);
            this.clientDetailsGroupBox.Name = "clientDetailsGroupBox";
            this.clientDetailsGroupBox.Size = new System.Drawing.Size(314, 523);
            this.clientDetailsGroupBox.TabIndex = 1;
            this.clientDetailsGroupBox.TabStop = false;
            this.clientDetailsGroupBox.Text = "Detalii client";
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.Location = new System.Drawing.Point(25, 208);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(156, 23);
            this.borrowBookButton.TabIndex = 7;
            this.borrowBookButton.Text = "Împrumută carte";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(25, 169);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(156, 23);
            this.addClientButton.TabIndex = 6;
            this.addClientButton.Text = "Adaugă client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Location = new System.Drawing.Point(103, 99);
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientPhoneTextBox.TabIndex = 5;
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Location = new System.Drawing.Point(103, 64);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientEmailTextBox.TabIndex = 4;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(103, 29);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientNameTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nume";
            // 
            // clientsListBox
            // 
            this.clientsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(8, 6);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(315, 524);
            this.clientsListBox.TabIndex = 0;
            this.clientsListBox.SelectedIndexChanged += new System.EventHandler(this.clientsListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sistem de Management al Bibliotecii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.bookDetailsGroupBox.ResumeLayout(false);
            this.bookDetailsGroupBox.PerformLayout();
            this.clientsTab.ResumeLayout(false);
            this.borrowedBooksGroupBox.ResumeLayout(false);
            this.clientDetailsGroupBox.ResumeLayout(false);
            this.clientDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage clientsTab;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.GroupBox bookDetailsGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookPagesTextBox;
        private System.Windows.Forms.TextBox bookYearTextBox;
        private System.Windows.Forms.TextBox bookGenreTextBox;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.GroupBox clientDetailsGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientPhoneTextBox;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.GroupBox borrowedBooksGroupBox;
        private System.Windows.Forms.ListBox borrowedBooksListBox;
        private System.Windows.Forms.Button borrowBookButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Label bookStatusLabel;
        private System.Windows.Forms.Label label10;
    }
}
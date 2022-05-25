using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class Form1 : Form
    {
        List<Study_Books> books = new List<Study_Books>();
        List<Research_Article> articles = new List<Research_Article>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddsbButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookID1TextBox.Text);
            string title = Title1TextBox.Text;
            string author = Author1TextBox.Text;
            string publisher = Publisher1TextBox.Text;
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            int ISBN = Convert.ToInt32(ISBNTextBox.Text);
            string genre = GenreTextBox.Text;

            if (quantity < 0)
                MessageBox.Show("Quantity can't be negative");

            Study_Books book = new Study_Books();
            book.id = id;
            book.title = title;
            book.author = author;
            book.publisher = publisher;
            book.quantity = quantity;
            book.ISBN = ISBN;
            book.genre = genre;

            books.Add(book);
            MessageBox.Show("Study book successfully added!");
        }

        private void AddraButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookID2TextBox.Text);
            string title = Title2TextBox.Text;
            string author = Author2TextBox.Text;
            string publisher = Publisher2TextBox.Text;
            int DOI = Convert.ToInt32(DOITextBox.Text);
            int published_date = Convert.ToInt32(DateTextBox.Text);
            string type = TypeTextBox.Text;
            int quantity = Convert.ToInt32(Quantity2TextBox.Text);

            Research_Article article = new Research_Article();
            article.id = id;
            article.title = title;
            article.author = author;
            article.publisher = publisher;
            article.quantity = quantity;
            article.DOI = DOI;
            article.published_date = published_date;
            article.type = type;

            articles.Add(article);

            MessageBox.Show("Research article has been added");

        }

        private void BorrorbookButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDTextBox.Text);

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].id == id)
                {
                    if (books.quantity > 0)
                    {
                        books[i].borrowBook();
                    }
                }

            }
            MessageBox.Show("Book borrowed");

        }

        private void BorrowArticleButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticleIDTextBox.Text);

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].id == id)
                {
                    if (articles[i].quantity > 0)
                    {
                        articles[i].borrowBook();
                    }
                }

            }
            MessageBox.Show("Book borrowed");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowbookButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ShowBookIDTextBox.Text);

            BookListBox.Items.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                if (id == books[i].id)
                {
                    BookListBox.Items.Add(books[i].getInfo());
                }
            }
        }

        private void ShowArticleButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ShowArticleIDTextBox.Text);


            ArticleListBox.Items.Clear();
            for (int i = 0; i < articles.Count; i++)
            {
                if (id == articles[i].id)
                {
                    ArticleListBox.Items.Add(articles[i].getInfo());
                }
            }
        }
    }
}
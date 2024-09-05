using Model;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class BookDAO
    {
        private SqlConnection dbConnection;

        public BookDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["Programming3"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }
            reader.Close();
            dbConnection.Close();

            return books;
        }

        public Book GetById(int bookId)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM books WHERE Id = @Id", dbConnection);

            cmd.Parameters.AddWithValue("@id", bookId);

            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;

            if (reader.Read())
            {
                book = ReadBook(reader);
            }
            reader.Close();
            dbConnection.Close();

            return book;
        }

        public List<Book> GetByAuthor(string authorName)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM books WHERE Author = @authorName", dbConnection);
            cmd.Parameters.AddWithValue("@authorName", authorName);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }
            reader.Close();
            dbConnection.Close();

            return books;
        }

        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            return new Book(id, title, author);
        }
    }
}

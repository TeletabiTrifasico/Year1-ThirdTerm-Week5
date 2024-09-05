using Model;
using DAL;

namespace ReservationSystemService
{
    public class BookService
    {
        BookDAO bookDao = new BookDAO();

        public List<Book> GetAll()
        {
            return bookDao.GetAll();
        }

        public Book GetById(int bookId)
        {
            return bookDao.GetById(bookId);
        }

        public List<Book> GetByAuthor(string authorName)
        {
            return bookDao.GetByAuthor(authorName);
        }
    }
}

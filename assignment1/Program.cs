using Model;
using ReservationSystemService;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            CustomerService customerService = new CustomerService();
            BookService bookService = new BookService();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing CustomerSerivce");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Enter customer id: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine(customerService.GetById(customerId));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing BookSerivce");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Enter name of author: ");
            string authorName = Console.ReadLine();
            List<Book> books = bookService.GetByAuthor(authorName);
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}


namespace Model
{
    public class Reservation
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public DateTime ReservationDateTime { get; set; }

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Customer = customer;
            Book = book;
        }

        public override string ToString()
        {
            return Customer.ToString() + " -> " + Book.ToString();
        }
    }
}

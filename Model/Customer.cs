namespace Model
{
    public class Customer
    {
        private int id;

        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string EmailAddress { get; set; }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return $"{FullName} ({EmailAddress})";
        }
    }
}

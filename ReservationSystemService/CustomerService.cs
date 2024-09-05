using Model;
using DAL;

namespace ReservationSystemService
{
    public class CustomerService
    {
        CustomerDAO customerDao = new CustomerDAO();

        public List<Customer> GetAll()
        {
            return customerDao.GetAll();
        }

        public Customer GetById(int customerId)
        {
            return customerDao.GetById(customerId);
        }
    }
}

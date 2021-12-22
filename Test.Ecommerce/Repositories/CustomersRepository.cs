using Test.Ecommerce.Customers.Models;

namespace Test.Ecommerce.Repositories
{
    public class CustomersRepository : IRepository<Customer>
    {
        private readonly List<Customer> _customers;

        public CustomersRepository()
        {
            _customers = new List<Customer>();
        }

        public void Delete(Customer customer)
        {
            _customers.Remove(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers;
        }

        public Customer GetById(int id)
        {
            return _customers.FirstOrDefault(customer => customer.Id == id);
        }

        public void Post(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            Customer UpdateCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (UpdateCustomer != null)
            {
                UpdateCustomer.CPF = customer.CPF;
                UpdateCustomer.Name = customer.Name;
                UpdateCustomer.Password = customer.Password;
                UpdateCustomer.Email = customer.Email;
                UpdateCustomer.Cellphone = customer.Cellphone;
                UpdateCustomer.Username = customer.Username;
            }
        }
    }
}

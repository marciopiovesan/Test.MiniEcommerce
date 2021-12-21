using Microsoft.AspNetCore.Mvc;
using Test.Ecommerce.Customers.Models;

namespace Test.Ecommerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController
    {
        private readonly List<Customer> _customers;

        //Buscar Clientes
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        //Buscar Cliente
        [HttpGet("{Id}")]
        public Customer Get(int Id)
        {
            return _customers.FirstOrDefault(customer => customer.Id == Id);
        }

        //Gravar Cliente
        [HttpPost]
        public void Post(Customer customer)
        {
            _customers.Add(customer);
        }

        //Atualizar Cliente
        [HttpPut]
        public void Put(Customer customer)
        {
            Customer TempCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (TempCustomer != null)
                TempCustomer = customer;
            //Ou copia todas as propriedades (uma por uma ou com reflection)
        }

        //Excluir Cliente
        [HttpDelete]
        public void Delete(int Id)
        {
            _customers.Remove(_customers.FirstOrDefault(customer => customer.Id == Id));
        }
    }
}

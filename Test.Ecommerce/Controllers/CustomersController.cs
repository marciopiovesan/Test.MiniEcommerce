using Microsoft.AspNetCore.Mvc;
using Test.Ecommerce.Customers.Models;
using Test.Ecommerce.Repositories;

namespace Test.Ecommerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController
    {
        private readonly IRepository<Customer> _customersRepository;

        public CustomersController(IRepository<Customer> repository) 
        { 
            _customersRepository = repository; 
        }

        //Buscar Clientes
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customersRepository.GetAll();
        }

        //Buscar Cliente
        [HttpGet("{Id}")]
        public Customer Get(int Id)
        {
           return _customersRepository.GetById(Id);
        }

        //Gravar Cliente
        [HttpPost]
        public void Post(Customer customer)
        {
            _customersRepository.Post(customer);
        }

        //Atualizar Cliente
        [HttpPut]
        public void Put(Customer customer)
        {
            _customersRepository.Update(customer);
        }

        //Excluir Cliente
        [HttpDelete]
        public void Delete(int Id)
        {
            Customer customer = _customersRepository.GetById(Id);
            _customersRepository.Delete(customer);
        }
    }
}

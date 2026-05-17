using Apps.Core.Contracts;
using Apps.Core.Models;
using Apps.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace App.Core.Services
{


    public class InMemoryCustomerService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();
      
          

        List<Customer> ICustomerService.GetAll()
        {
            return _customers.ToList();
        }
        Customer ICustomerService.GetById(string id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
        void ICustomerService.Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer Object is null");
            _customers.Add(customer);
        }
        public void Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);

            if (existing == null)
                throw new Exception($"Customer with {customer.Id} not found");

            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.Phone = customer.Phone;
            existing.Address = customer.Address;
        }
        public void Delete(string id)
        {
            _customers.RemoveAll(c => c.Id == id);

        }
        public List<Customer> GetAll()       // <-- This is where GetAll is actually defined
        {
            return _customers;
        }

        public List<Customer>Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetAll();

            return _customers.Where(c =>
              c.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
              c.Email.Contains(query, StringComparison.OrdinalIgnoreCase) ||
              c.Phone.Contains(query, StringComparison.OrdinalIgnoreCase)
               ).ToList();
        }
    }
}
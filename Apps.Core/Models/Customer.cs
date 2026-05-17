using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Core.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Customer()
        {
            Id = "C_" + Guid.NewGuid().ToString("N").Substring(0,9);
        }
    
        
    }
}

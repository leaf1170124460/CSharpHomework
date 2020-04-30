using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Customer:ICloneable
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{Phone}\t{Address}";
        }

        public object Clone()
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = this.Name;
            newCustomer.Phone = this.Phone;
            newCustomer.Address = this.Address;
            return newCustomer;
        }
    }
}

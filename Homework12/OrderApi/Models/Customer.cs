using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Serializable]
public class Customer : ICloneable
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }
 
    public string Address { get; set; }

    public object Clone()
    {
        Customer newCustomer = new Customer();
        newCustomer.Name = this.Name;
        newCustomer.Phone = this.Phone;
        newCustomer.Address = this.Address;
        return newCustomer;
    }
}

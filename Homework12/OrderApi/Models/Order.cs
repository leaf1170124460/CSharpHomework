﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

[Serializable]
public class Order : IComparable<Order>, ICloneable
{
    private List<OrderItem> items;

    [Key]
    public long OrderCode { get; set; }
    public long CustomerId{get;set;}

    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }


    public List<OrderItem> Items
    {
        get { return items; }
        set { items = value; }
    }
    [NotMapped]
    public float Total
    {
        get
        {
            float total = 0.0F;
            foreach (OrderItem e in Items)
            {
                total += e.Commodity.Price * e.Count;
            }
            return total;
        }
    }

    public Order()
    {
        items = new List<OrderItem>();
        Customer = new Customer();
    }

    public override bool Equals(object obj)
    {
        Order order = obj as Order;
        return order != null && OrderCode == order.OrderCode;
    }

    public override int GetHashCode()
    {
        return (int)OrderCode;
    }

    public int CompareTo(Order obj)
    {
        return Total.CompareTo(obj.Total);
    }

    public object Clone()
    {
        Order newOrder = new Order();
        newOrder.OrderCode = this.OrderCode;
        newOrder.Customer = (Customer)this.Customer.Clone();
        for (int i = 0; i < this.Items.Count; i++)
        {
            newOrder.Items.Add((OrderItem)this.Items[i].Clone());
        }
        return newOrder;
    }
}

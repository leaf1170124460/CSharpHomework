using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Serializable]
public class OrderItem : IComparable<OrderItem>, ICloneable
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public long CommodityId{get;set;}

    [ForeignKey("CommodityId")]
    public Commodity Commodity { get; set; }

    public int Count { get; set; }

    public OrderItem()
    {
        Commodity = new Commodity();
    }

    public override bool Equals(object obj)
    {
        OrderItem item = obj as OrderItem;
        return item != null && Commodity.Id == item.Commodity.Id;
    }

    public override int GetHashCode()
    {
        return (int)Id;
    }

    public int CompareTo(OrderItem obj)
    {
        return Commodity.Id.CompareTo(obj.Commodity.Id);
    }

    public object Clone()
    {
        OrderItem newOrderItem = new OrderItem();
        newOrderItem.Commodity = (Commodity)this.Commodity.Clone();
        newOrderItem.Count = this.Count;
        return newOrderItem;
    }
}

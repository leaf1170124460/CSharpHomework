using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Serializable]
public class Commodity : ICloneable
{
    public long Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }

    public object Clone()
    {
        Commodity newCommodity = new Commodity();
        newCommodity.Id = this.Id;
        newCommodity.Name = this.Name;
        newCommodity.Price = this.Price;
        return newCommodity;
    }

    public override bool Equals(object obj)
    {
        Commodity commodity = obj as Commodity;
        return this.Id == commodity.Id;
    }

    public override int GetHashCode()
    {
        return (int)Id;
    }
}

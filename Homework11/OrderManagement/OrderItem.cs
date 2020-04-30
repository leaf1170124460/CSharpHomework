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
    public class OrderItem:IComparable<OrderItem>,ICloneable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public Commodity Commodity { get; set; }
        [NotMapped]
        public long CommodityCode { get { return Commodity.Id; } set { Commodity.Id = value; } }
        [NotMapped]
        public string CommodityName { get { return Commodity.Name; } set { Commodity.Name = value; } }
        [NotMapped]
        public float CommodityPrice { get { return Commodity.Price; } set { Commodity.Price = value; } }
        [Required]
        public int Count { get; set; }

        public OrderItem()
        {
            Commodity = new Commodity();
        }

        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item!=null&&Commodity.Id == item.Commodity.Id;
        }

        public override int GetHashCode()
        {
            return (int)Id;
        }

        public override string ToString()
        {
            return $"{Commodity}\t{Count}\n";
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
}

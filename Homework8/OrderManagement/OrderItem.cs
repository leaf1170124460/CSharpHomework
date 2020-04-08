using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class OrderItem:IComparable<OrderItem>,ICloneable
    {
        public Commodity Commodity { get; set; }
        public string CommodityCode { get { return Commodity.Code; } set { Commodity.Code = value; } }
        public string CommodityName { get { return Commodity.Name; } set { Commodity.Name = value; } }
        public float CommodityPrice { get { return Commodity.Price; } set { Commodity.Price = value; } }
        public int Count { get; set; }

        public OrderItem()
        {
            Commodity = new Commodity();
        }

        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item!=null&&Commodity.Code==item.Commodity.Code;
        }

        public override int GetHashCode()
        {
            if (Commodity.Code == null)
            {
                return -1;
            }
            return int.Parse(Commodity.Code);
        }

        public override string ToString()
        {
            return $"{Commodity}\t{Count}\n";
        }

        public int CompareTo(OrderItem obj)
        {
            return Commodity.Code.CompareTo(obj.Commodity.Code);
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

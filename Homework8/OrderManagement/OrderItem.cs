using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class OrderItem:IComparable<OrderItem>
    {
        public Commodity Commodity { get; set; }
        public string CommodityCode { get { return Commodity.Code; } }
        public string CommodityName { get { return Commodity.Name; } }
        public float CommodityPrice { get { return Commodity.Price; } }
        public int Count { get; set; }

        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item!=null&&Commodity.Code==item.Commodity.Code;
        }

        public override int GetHashCode()
        {
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

    }
}

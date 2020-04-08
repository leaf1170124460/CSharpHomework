using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Order : IComparable<Order>,ICloneable
    {
        private List<OrderItem> items;

        public string OrderCode { get; set; }
        public Customer Customer { get; set; }
        public string CustomerName { get { return Customer.Name; }  set { Customer.Name = value; } }
        public string CustomerPhone { get { return Customer.Phone; }  set { Customer.Phone = value; } }
        public string CustomerAddress { get { return Customer.Address; }  set { Customer.Address = value; } }
        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value.Distinct().ToList(); }
        }
        public float Total {
            get
            {
                float total = 0.0F;
                foreach(OrderItem e in Items)
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

        public bool AddItem(OrderItem orderItem)
        {
            if (!Items.Contains(orderItem))
            {
                Items.Add(orderItem);
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && OrderCode == order.OrderCode;
        }

        public override int GetHashCode()
        {
            if (OrderCode == null)
            {
                return -1;
            }
            return int.Parse(OrderCode);
        }

        public override string ToString()
        {
            //输出所有OrderItem的信息
            StringBuilder details = new StringBuilder();
            foreach (OrderItem e in Items)
            {
                details.Append(e);
            }
            return $"{OrderCode}\n{Customer}\n{details.ToString()}Total: ${Total}\n";
        }

        public int CompareTo(Order obj)
        {
            return OrderCode.CompareTo(obj.OrderCode);
        }

        public object Clone()
        {
            Order newOrder = new Order();
            newOrder.OrderCode = this.OrderCode;
            newOrder.Customer = (Customer)this.Customer.Clone();
            for(int i = 0; i < this.Items.Count; i++)
            {
                newOrder.AddItem((OrderItem)this.Items[i].Clone());
            }
            return newOrder;
        }
    }
}

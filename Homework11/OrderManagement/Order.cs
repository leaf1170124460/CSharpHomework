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
    public class Order : IComparable<Order>,ICloneable
    {
        private List<OrderItem> items;

        [Key]
        public long OrderCode { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [NotMapped]
        public string CustomerName { get { return Customer.Name; }  set { Customer.Name = value; } }
        [NotMapped]
        public string CustomerPhone { get { return Customer.Phone; }  set { Customer.Phone = value; } }
        [NotMapped]
        public string CustomerAddress { get { return Customer.Address; }  set { Customer.Address = value; } }
        [Required]
        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        [NotMapped]
        public float Total {
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

        public bool AddItem(OrderItem orderItem)
        {
            using (var db = new OrderContext())
            {
                db.OrderItems.Add(orderItem);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
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
            return Total.CompareTo(obj.Total);
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

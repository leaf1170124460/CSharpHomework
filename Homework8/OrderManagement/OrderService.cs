using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagement
{
    public class OrderService
    {
        private List<Order> orderList;

        public List<Order> OrderList
        {
            get
            {
                return orderList;
            }

            set
            {
                orderList = value;
            }
        }

        public OrderService()
        {
            OrderList = new List<Order>();
        }
        //添加订单
        public bool AddOrder(Order newOrder)
        {
            if (!OrderList.Contains(newOrder))
            {
                OrderList.Add(newOrder);
                return true;
            }else
            {
                return false;
            }
        }

        //删除订单
        public bool DeleteOrder(string orderCode)
        {
            Order deleteOrder = new Order() { OrderCode = orderCode };
            int index = OrderList.IndexOf(deleteOrder);
            if (index == -1)
            {
                return false;
                throw new Exception("There is no such order!");
            }else
            {
                OrderList.RemoveAt(index);
                return true;
            }
        }

        //修改订单
        public bool UpdateOrder(string orderCode,Order updateOrder)
        {
            Order updatedOrder = new Order() { OrderCode = orderCode };
            int index = OrderList.IndexOf(updatedOrder);
            if (index == -1)
            {
                return false;
                throw new Exception("There is no such order!");
            }
            else
            {
                OrderList[index] = updateOrder;
                return true;
            }
        }

        //查询订单
        public IEnumerable<Order> SelectOrder(string from,string condition)
        {
            switch (from)
            {
                case "Order Code":
                    IEnumerable<Order> query1 = from n in OrderList
                                                where n.OrderCode == condition
                                                orderby n.Total
                                                select n ;
                    return query1;
                
                case "Customer Name":
                    IEnumerable<Order> query2 = from n in OrderList
                                                where n.Customer.Name==condition
                                                orderby n.Total
                                                select n;
                    return query2;

                case "Commodity Name":
                    IEnumerable<Order> query3 = from n in OrderList
                                                from i in n.Items
                                                where i.Commodity.Name==condition
                                                orderby n.Total
                                                select n;
                    return query3;

                default:return null;
            }
        }

        //默认订单排序
        public void Sort()
        {
            OrderList.Sort();
        }

        //自定义订单排序
        public void Sort(Comparison<Order> comparison)
        {
            OrderList.Sort(comparison);
        }

        //输出订单到XML文件
        public void Export(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs,OrderList);
            }
        }

        //从XML文件导入订单
        public void Import(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> importedOrderList = (List<Order>)xmlSerializer.Deserialize(fs);
                for(int i = 0; i < importedOrderList.Count; i++)
                {
                    AddOrder(importedOrderList[i]);
                }
            }
        }
    }
}

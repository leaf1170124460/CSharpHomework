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
        public List<Order> orderList=new List<Order>();

        //添加订单
        public void AddOrder(Order newOrder)
        {
            if (!orderList.Contains(newOrder))
            {
                orderList.Add(newOrder);
            }
        }

        //删除订单
        public void DeleteOrder(string orderCode)
        {
            Order deleteOrder = new Order() { OrderCode = orderCode };
            int index = orderList.IndexOf(deleteOrder);
            if (index == -1)
            {
                throw new Exception("There is no such order!");
            }else
            {
                orderList.RemoveAt(index);
            }
        }

        //修改订单
        public void UpdateOrder(string orderCode,Order updateOrder)
        {
            Order deleteOrder = new Order() { OrderCode = orderCode };
            int index = orderList.IndexOf(deleteOrder);
            if (index == -1)
            {
                throw new Exception("There is no such order!");
            }
            else
            {
                orderList[index] = updateOrder;
            }
        }

        //查询订单
        public IEnumerable<Order> SelectOrder(string from,string condition)
        {
            switch (from)
            {
                case "OrderCode":
                    IEnumerable<Order> query1 = from n in orderList
                                                where n.OrderCode == condition
                                                orderby n.Total
                                                select n ;
                    return query1;
                
                case "CustomerName":
                    IEnumerable<Order> query2 = from n in orderList
                                                where n.Customer.Name==condition
                                                orderby n.Total
                                                select n;
                    return query2;

                case "CommodityName":
                    IEnumerable<Order> query3 = from n in orderList
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
            orderList.Sort();
        }

        //自定义订单排序
        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

        //打印订单
        public void Print()
        {
            foreach (Order e in orderList)
            {
                Console.WriteLine(e);
            }
        }

        //输出订单到XML文件
        public void Export(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs,orderList);
            }
        }

        //从XML文件导入订单
        public void Import(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                orderList = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
    }
}

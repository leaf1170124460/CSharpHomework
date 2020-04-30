using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagement
{
    public class OrderService
    {
        //添加订单
        public bool AddOrder(Order newOrder)
        {
            using(var db=new OrderContext())
            {
                db.Orders.Add(newOrder);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        //删除订单
        public bool DeleteOrder(long orderCode)
        {
            using(var db=new OrderContext())
            {
                var deleteOrder = db.Orders.
                    Include(o=>o.Items).
                    Include(o=>o.Customer).
                    Include(o => o.Items.Select(i => i.Commodity)).
                    FirstOrDefault(order => order.OrderCode == orderCode);

                if(deleteOrder != null){
                    db.Orders.Remove(deleteOrder);
                    int result=db.SaveChanges();
                    return result>0?true:false;
                }
                return false;
            }
        }

        //修改订单
        public bool UpdateOrder(long orderCode,Order updateOrder)
        {
            using (var db = new OrderContext())
            {
                var oldOrder = db.Orders.
                    Include(o => o.Items).
                    Include(o => o.Customer).
                    Include(o => o.Items.Select(i => i.Commodity)).
                    FirstOrDefault(o => o.OrderCode == orderCode);

                if (oldOrder != null)
                {
                    oldOrder.Customer = updateOrder.Customer;
                    oldOrder.Items = updateOrder.Items;
                    db.Entry(oldOrder).State = EntityState.Modified;
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
                return false; 
            }
        }

        //查询订单
        public List<Order> SelectOrder(string from,string condition)
        {
            using(var db=new OrderContext())
            {
                switch (from)
                {
                    case "Order Code":
                        long orderCode=0;
                        long.TryParse(condition, out orderCode);
                        List<Order> list1 = db.Orders.
                            Include(o => o.Items).
                            Include(o => o.Customer).
                            Include(o => o.Items.Select(i => i.Commodity)).
                            Where(o => o.OrderCode == orderCode).ToList();
                        list1.Sort();
                        return list1;

                    case "Customer Name":
                        List<Order> list2 = db.Orders.
                            Include(o => o.Items).
                            Include(o => o.Customer).
                            Include(o => o.Items.Select(i => i.Commodity)).
                            Where(o => o.Customer.Name == condition).ToList();
                        list2.Sort();
                        return list2;

                    case "Commodity Name":
                        List<Order> list3 = db.Orders.
                            Include(o => o.Items).
                            Include(o => o.Customer).
                            Include(o => o.Items.Select(i => i.Commodity)).
                            Where(o => o.Items.Any(i=>i.Commodity.Name==condition)).ToList();
                        list3.Sort();
                        return list3;

                    case "All":
                        List<Order> list4 = db.Orders.
                            Include(o => o.Items).
                            Include(o => o.Customer).
                            Include(o => o.Items.Select(i => i.Commodity)).ToList();
                        list4.Sort();
                        return list4;

                    default:
                        return null;
                }
            
            }
        }

        //输出订单到XML文件
        public void Export(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(var db=new OrderContext())
            {
                List<Order> orderList = db.Orders.
                            Include(o => o.Items).
                            Include(o => o.Customer).
                            Include(o => o.Items.Select(i => i.Commodity)).ToList();
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, orderList);
                }
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

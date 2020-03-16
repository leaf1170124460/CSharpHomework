using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();

            //有两个Order的订单号相同，应该只有一个成功加入
            //Order 4中有两个OrderItem相同，应该只有一个成功加入
            Order firstOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 3 } } };
            Order fourthOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 6 } } };
            Order fifthOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 10 } } };

            try
            {
                //添加订单
                Console.WriteLine("-------------Add Order-------------");
                service.AddOrder(firstOrder);
                service.AddOrder(secondOrder);
                service.AddOrder(thirdtOrder);
                service.AddOrder(fourthOrder);
                service.AddOrder(fifthOrder);
                service.Print();

                //默认排序
                Console.WriteLine("-------------Default Sort----------");
                service.Sort();
                service.Print();

                //自定义排序
                Console.WriteLine("-------------Customized Sort-------");
                service.Sort((o1, o2) => { return (int)(o1.Total - o2.Total);});
                service.Print();


                //删除Order 5 订单
                Console.WriteLine("-------------Delete Order 5--------");
                service.DeleteOrder("5");
                service.Print();


                //更新Order 4 订单
                Console.WriteLine("-------------Update Order 4--------");
                Order updateOrder = secondOrder;
                secondOrder.Items[0].Count = 10;
                service.UpdateOrder("4", updateOrder);
                service.Print();

                //查询订单号为2的订单
                Console.WriteLine("-------------Select Order 2--------");
                IEnumerable<Order> result1=service.SelectOrder("OrderCode", "2");
                foreach(Order e in result1)
                {
                    Console.WriteLine(e);
                }

                //查询商品名为Pen的订单
                Console.WriteLine("-------------Select Pen------------");
                IEnumerable<Order> result2 = service.SelectOrder("CommodityName", "Pen");
                foreach (Order e in result2)
                {
                    Console.WriteLine(e);
                }


                //查询客户名为Amy的订单
                Console.WriteLine("-------------Select Amy------------");
                IEnumerable<Order> result3 = service.SelectOrder("CustomerName", "Amy");
                foreach (Order e in result3)
                {
                    Console.WriteLine(e);
                }
            }
            catch (Exception e)
            {
                //显示错误信息
                Console.WriteLine(e.Message);
            }
        }
    }
}

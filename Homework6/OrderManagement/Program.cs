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

            Order firstOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 3 } } };
            Order fourthOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 6 } } };
            Order fifthOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 10 } } };

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

                //输出订单到XML文件
                Console.WriteLine("-------------Export Orders----------");
                service.Export(@"E:\order.xml");
                Console.WriteLine("Successfully Exported.\n");

                //删除所有订单
                Console.WriteLine("-------------Delete All Orders------");
                service.DeleteOrder("1");
                service.DeleteOrder("2");
                service.DeleteOrder("3");
                service.DeleteOrder("4");
                service.DeleteOrder("5");
                Console.WriteLine("Successfully Deleted.\n");
                service.Print();

                //从XML文件导入订单
                Console.WriteLine("-------------Import Orders----------");
                service.Import(@"E:\order.xml");
                Console.WriteLine("Successfully Imported.\n");
                service.Print();
            }
            catch (Exception e)
            {
                //显示错误信息
                Console.WriteLine(e.Message);
            }
        }
    }
}

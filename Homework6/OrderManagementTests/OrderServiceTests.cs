using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        //正常添加Order
        [TestMethod()]
        public void AddOrderTest()
        {
            Order newOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service=new OrderService();
            service.AddOrder(newOrder);

            Order addedOrder= service.orderList[0];

            Assert.AreEqual(newOrder,addedOrder);
        }

        //添加重复Order
        [TestMethod()]
        public void AddOrderTest1()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> addedOrders = service.orderList;

            List<Order> orders = new List<Order>();
            orders.Add(firstOrder);

            CollectionAssert.AreEqual(orders, addedOrders);
        }

        //添加null
        [TestMethod()]
        public void AddOrderTest2()
        {
            Order newOrder = null;
            OrderService service = new OrderService();
            service.AddOrder(newOrder);
            Order addedOrder = service.orderList[0];

            Assert.IsNull(addedOrder);
        }

        //正常删除Order
        [TestMethod()]
        public void DeleteOrderTest()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            service.DeleteOrder("2");
            List<Order> deletedOrders = service.orderList;

            List<Order> orders = new List<Order>();
            orders.Add(firstOrder);

            CollectionAssert.AreEqual(orders,deletedOrders);
        }

        //删除不存在的Order
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void DeleteOrderTest1()
        {
            Order newOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(newOrder);
            service.DeleteOrder("10");
        }

        //正常更新Order
        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.UpdateOrder("1",secondOrder);

            Order updatedOrder = service.orderList[0];

            Assert.AreEqual(secondOrder, updatedOrder);
        }

        //更新不存在的Order
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void UpdateOrderTest1()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.UpdateOrder("10", secondOrder);
        }

        //更新Order为null
        [TestMethod()]
        public void UpdateOrderTest2()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = null;
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.UpdateOrder("1", secondOrder);
            Order updatedOrder = service.orderList[0];

            Assert.IsNull(updatedOrder);
        }

        //正常通过客户名查询Order
        [TestMethod()]
        public void SelectOrderTest()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> selectedOrders = service.SelectOrder("CustomerName", "Mike").ToList();

            List<Order> orders = new List<Order>();
            orders.Add(secondOrder);
            orders.Add(firstOrder);

            CollectionAssert.AreEqual(orders,selectedOrders);
        }

        //正常通过订单号查询Order
        [TestMethod()]
        public void SelectOrderTest1()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> selectedOrders = service.SelectOrder("OrderCode", "1").ToList();

            List<Order> orders = new List<Order>();
            orders.Add(firstOrder);

            CollectionAssert.AreEqual(orders, selectedOrders);
        }

        //正常通过商品名查询Order
        [TestMethod()]
        public void SelectOrderTest2()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> selectedOrders = service.SelectOrder("CommodityName", "Pen").ToList();

            List<Order> orders = new List<Order>();
            orders.Add(secondOrder);
            orders.Add(firstOrder);

            CollectionAssert.AreEqual(orders, selectedOrders);
        }

        //查询不存在客户名
        [TestMethod()]
        public void SelectOrderTest3()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> selectedOrders = service.SelectOrder("CustomerName", "Amy").ToList();

            List<Order> orders = new List<Order>();

            CollectionAssert.AreEqual(orders, selectedOrders);
        }

        //查询不存在订单号
        [TestMethod()]
        public void SelectOrderTest4()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> selectedOrders = service.SelectOrder("OrderCode", "10").ToList();

            List<Order> orders = new List<Order>();

            CollectionAssert.AreEqual(orders, selectedOrders);
        }

        //查询不存在商品名
        [TestMethod()]
        public void SelectOrderTest5()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            List<Order> selectedOrders = service.SelectOrder("CommodityName", "Telescope").ToList();

            List<Order> orders = new List<Order>();

            CollectionAssert.AreEqual(orders, selectedOrders);
        }

        //查询不存在字段
        [TestMethod()]
        public void SelectOrderTest6()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            IEnumerable<Order> selectedOrders = service.SelectOrder("CustomerPhone", "1");

            Assert.IsNull(selectedOrders);
        }

        //正常按订单号排序
        [TestMethod()]
        public void SortTest()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order secondOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order fourthOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order fifthOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            service.AddOrder(thirdtOrder);
            service.AddOrder(fourthOrder);
            service.AddOrder(fifthOrder);
            service.Sort();
            List<Order> sortedOrders = service.orderList;

            List<Order> orders = new List<Order>();
            orders.Add(firstOrder);
            orders.Add(thirdtOrder);
            orders.Add(fifthOrder);
            orders.Add(fourthOrder);
            orders.Add(secondOrder);

            CollectionAssert.AreEqual(orders, sortedOrders);
        }

        //正常自定义排序
        [TestMethod()]
        public void SortTest1()
        {
            Order firstOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order secondOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order fourthOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order fifthOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            service.AddOrder(thirdtOrder);
            service.AddOrder(fourthOrder);
            service.AddOrder(fifthOrder);
            service.Sort((o1, o2) => { return (int)(o1.Total - o2.Total); });
            List<Order> sortedOrders = service.orderList;

            List<Order> orders = new List<Order>();
            orders.Add(fifthOrder);
            orders.Add(fourthOrder);
            orders.Add(thirdtOrder);
            orders.Add(secondOrder);
            orders.Add(firstOrder);

            CollectionAssert.AreEqual(orders, sortedOrders);
        }

        //输出Order到XML文件
        [TestMethod()]
        public void ExportTest()
        {
            Order firstOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 3 } } };
            Order fourthOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 6 } } };
            Order fifthOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 10 } } };
            OrderService service = new OrderService();
            service.AddOrder(firstOrder);
            service.AddOrder(secondOrder);
            service.AddOrder(thirdtOrder);
            service.AddOrder(fourthOrder);
            service.AddOrder(fifthOrder);
            service.Export("order.xml");

            //文件比较
            using (FileStream corret = new FileStream(@"..\..\orderCorret.xml", FileMode.Open))
            {
                using(FileStream output = new FileStream("order.xml", FileMode.Open))
                {
                    if (corret.Length != output.Length)
                    {
                        Assert.Fail();
                    }
                    int corretByte = 0, outputByte = 0;
                    do
                    {
                        corretByte = corret.ReadByte();
                        outputByte = output.ReadByte();
                    } while (corretByte == outputByte && corretByte != -1  && outputByte != -1);
                    Assert.AreEqual(corretByte, outputByte);
                }
            }
        }

        //从XML文件导入Order
        [TestMethod()]
        public void ImportTest()
        {
            Order firstOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 3 } } };
            Order fourthOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 6 } } };
            Order fifthOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 10 } } };
            OrderService service = new OrderService();
            service.Import("../../orderCorret.xml");
            List<Order> importedOrders = service.orderList;

            List<Order> orders = new List<Order>();
            orders.Add(firstOrder);
            orders.Add(secondOrder);
            orders.Add(thirdtOrder);
            orders.Add(fourthOrder);
            orders.Add(fifthOrder);

            CollectionAssert.AreEqual(orders, importedOrders);
        }
    }
}
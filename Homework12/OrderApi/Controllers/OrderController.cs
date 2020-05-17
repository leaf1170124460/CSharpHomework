using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly OrderContext orderDb;

    public OrderController(OrderContext context)
    {
        this.orderDb = context;

        /*
        //初始化数据
        Customer mike = new Customer {Id=100L,Name = "Mike", Phone = "13845691234", Address = "Wuhan" };
        Customer amy = new Customer {Id=101L,Name = "Amy", Phone = "13845123457", Address = "Beijing" };
        Customer john = new Customer {Id=102L, Name = "John", Phone = "13845123466", Address = "Shanghai" };
        Customer bob = new Customer { Id=103L,Name = "Bob", Phone = "13845123156", Address = "Guangzhou" };

        orderDb.Customers.Add(mike);
        orderDb.Customers.Add(amy);
        orderDb.Customers.Add(john);
        orderDb.Customers.Add(bob);
        orderDb.SaveChanges();

        Commodity phone = new Commodity() { Id=123456L,Name = "Phone", Price = 3999.9F };
        Commodity pen = new Commodity() {Id=123457L,Name = "Pen", Price = 9.5F };
        Commodity earphone = new Commodity() {Id=123458L,Name = "Earphone", Price = 399.9F };

        orderDb.Commodities.Add(phone);
        orderDb.Commodities.Add(pen);
        orderDb.Commodities.Add(earphone);
        orderDb.SaveChanges();

        Order firstOrder = new Order() { OrderCode=1L,CustomerId = mike.Id,Customer=mike,Items = new List<OrderItem>() { new OrderItem() { CommodityId = phone.Id,Commodity=null, Count = 2 }, new OrderItem() { CommodityId = pen.Id,Commodity=null, Count = 30 } } };
        Order secondOrder = new Order() { OrderCode=2L,CustomerId = amy.Id,Customer=amy, Items = new List<OrderItem>() { new OrderItem() { CommodityId = phone.Id,Commodity=null, Count = 1 }, new OrderItem() { CommodityId = pen.Id,Commodity=null, Count = 1 } } };
        Order thirdtOrder = new Order() { OrderCode=3L,CustomerId = john.Id,Customer=john, Items = new List<OrderItem>() { new OrderItem() { CommodityId = earphone.Id,Commodity=null, Count = 3 }, new OrderItem() { CommodityId = pen.Id,Commodity=null, Count = 3 } } };
        Order fourthOrder = new Order() { OrderCode=4L,CustomerId = bob.Id,Customer=bob, Items = new List<OrderItem>() { new OrderItem() { CommodityId = phone.Id,Commodity=null, Count = 4 }, new OrderItem() { CommodityId = pen.Id,Commodity=null, Count = 6 } } };
        Order fifthOrder = new Order() { OrderCode=5L,CustomerId = amy.Id,Customer=amy, Items = new List<OrderItem>() { new OrderItem() { CommodityId = phone.Id,Commodity=null, Count = 5 }, new OrderItem() { CommodityId = pen.Id,Commodity=null, Count = 10 } } };

        this.AddOrder(firstOrder);
        this.AddOrder(secondOrder);
        this.AddOrder(thirdtOrder);
        this.AddOrder(fourthOrder);
        this.AddOrder(fifthOrder);
        */

    }

    //添加订单
    [HttpPost]
    public ActionResult<Order> AddOrder(Order newOrder)
    {
        try
        {
            orderDb.Orders.Add(newOrder);
            orderDb.SaveChanges();
        }
        catch (Exception e)
        {
            string errorMessage = e.Message;
            if (e.InnerException.Message != null)
            {
                errorMessage = e.InnerException.Message;
            }
            return BadRequest(errorMessage);
        }
        return newOrder;
    }

    //根据订单号删除订单
    //DELETE: api/order/{orderCode}  orderCode为路径参数
    [HttpDelete("{orderCode}")]
    public ActionResult<Order> DeleteOrder(long orderCode)
    {
        try
        {
            Order deleteOrder = orderDb.Orders.
                                    Include(o => o.Items).
                                    FirstOrDefault(o => o.OrderCode == orderCode);

            if (deleteOrder != null)
            {
                orderDb.Orders.Remove(deleteOrder);
                orderDb.SaveChanges();
            }
        }
        catch (Exception e)
        {
            string errorMessage = e.Message;
            if (e.InnerException != null)
            {
                errorMessage = e.InnerException.Message;
            }
            return BadRequest(errorMessage);
        }
        return NoContent();
    }

    //修改订单
    //PUT: api/order/{orderCode}  orderCode为路径参数
    [HttpPut("{orderCode}")]
    public ActionResult<Order> UpdateOrder(long orderCode, Order updateOrder)
    {
        try
        {
            Order oldOrder = orderDb.Orders.
                            Include(o => o.Customer).
                            Include(o => o.Items).
                                ThenInclude(i => i.Commodity).
                            FirstOrDefault(order => order.OrderCode == orderCode);


            if (oldOrder != null)
            {
                oldOrder.Customer = updateOrder.Customer;
                oldOrder.Items = updateOrder.Items;
                orderDb.Entry(oldOrder).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
        }
        catch (Exception e)
        {
            string errorMessage = e.Message;
            if (e.InnerException.Message != null)
            {
                errorMessage = e.InnerException.Message;
            }
            return BadRequest(errorMessage);
        }
        return NoContent();
    }

    //查询订单
    //GET: api/order
    //GET: api/order?customerName=Mike&commodityName=Phone
    [HttpGet]
    public ActionResult<List<Order>> SelectOrders(string customerName, string commodityName)
    {
        IQueryable<Order> query = BuildQuery(customerName, commodityName);
        List<Order> orderList = query.ToList();
        orderList.Sort();
        return orderList;
    }

    //根据订单号查询订单
    //GET: api/order/{orderCode}  orderCode为路径参数
    [HttpGet("{orderCode}")]
    public ActionResult<Order> SelectOrdersByOrderCode(long orderCode)
    {
        Order selectedOrder = orderDb.Orders.
                                Include(o => o.Customer).
                                Include(o => o.Items).
                                    ThenInclude(i => i.Commodity).
                                FirstOrDefault(o => o.OrderCode == orderCode);
        if (selectedOrder == null)
        {
            return NotFound();
        }
        return selectedOrder;
    }

    //构造Query
    public IQueryable<Order> BuildQuery(string customerName, string commodityName)
    {

        IQueryable<Order> query = orderDb.Orders.
                                    Include(o => o.Customer).
                                    Include(o => o.Items).
                                        ThenInclude(i => i.Commodity).
                                    Where(o=>o.OrderCode!=0);
        if (customerName != null)
        {
            query = query.
                        Include(o => o.Customer).
                        Include(o => o.Items).
                            ThenInclude(i => i.Commodity).
                        Where(o => o.Customer.Name == customerName);
        }
        if (commodityName != null)
        {
            query = query.
                        Include(o => o.Customer).
                        Include(o => o.Items).
                            ThenInclude(i => i.Commodity).
                        Where(o => o.Items.Any(i => i.Commodity.Name == commodityName));
        }
        
        return query;
    }
}

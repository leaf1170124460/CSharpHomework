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
    }

    //添加订单
    [HttpPost]
    public ActionResult<Order> PostOrder(Order newOrder)
    {
        try
        {
            newOrder.Customer=null;
            newOrder.Items.ForEach(i=>i.Commodity=null);
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
    public ActionResult<Order> PutOrder(long orderCode, Order updateOrder)
    {
        try
        {
            if(orderCode!=updateOrder.OrderCode){
                return BadRequest("Order code can't be modified.");
            }

            //移除旧订单项
            var oldItems=orderDb.OrderItems.Where(i=>i.OrderId==orderCode);
            orderDb.OrderItems.RemoveRange(oldItems);

            //添加修改后的订单项
            updateOrder.Items.ForEach(i=>i.Commodity=null);
            orderDb.OrderItems.AddRange(updateOrder.Items);

            //订单标记为修改
            orderDb.Entry(updateOrder).State = EntityState.Modified;
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
        return NoContent();
    }

    //查询订单
    //GET: api/order
    //GET: api/order?customerName=Mike&commodityName=Phone
    [HttpGet]
    public ActionResult<List<Order>> GetOrders(string customerName, string commodityName)
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

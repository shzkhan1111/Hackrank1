using System;
using System.Linq;
using System.Numerics;
using ConsoleApp1.Service;
using ConsoleApp1.Model;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp1
{


    class Program
    {
        class Order
        {
            public int OrderID { get; set; }
            public int CustomerID { get; set; }
            public string OrderDate { get; set; }
        }

        class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
        }

        class

        OrderDetail
        {
            public

        int OrderID
            { get; set; }
            public

        int ProductID
            { get; set; }
            public

        decimal UnitPrice
            { get; set; }
            public

        int Quantity
            { get; set; }
        }

        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>()
{
    new Order() { OrderID = 1, CustomerID = 100, OrderDate = "2023-01-01" },
    new Order() { OrderID = 2, CustomerID = 200, OrderDate = "2023-02-02" },
    new Order() { OrderID = 3, CustomerID = 300, OrderDate = "2023-03-03" }
};

            List<Product> products = new List<Product>()
{
    new Product() { ProductID = 1, ProductName = "Product A", UnitPrice = 10.00M },
    new Product() { ProductID = 2, ProductName = "Product B", UnitPrice = 20.00M },
    new Product() { ProductID = 3, ProductName = "Product C", UnitPrice = 30.00M }
};

            List<OrderDetail> orderDetails = new List<OrderDetail>()
{
    new OrderDetail() { OrderID = 1, ProductID = 1, UnitPrice = 9.50M, Quantity = 2 },
    new OrderDetail() { OrderID = 1, ProductID = 2, UnitPrice = 19.80M, Quantity = 1 },
    new OrderDetail() { OrderID = 2, ProductID = 2, UnitPrice = 20.50M, Quantity = 3 },
    new OrderDetail() { OrderID = 3, ProductID = 3, UnitPrice = 29.90M, Quantity = 5 }
};
            var query = from o in orders
                        from p in products
                        join d in orderDetails
                            on new { o.OrderID, p.ProductID } equals new { d.OrderID, d.ProductID } into details
                        from d in details
                        select new { o.OrderID, p.ProductID, d.UnitPrice };

            // Execute the query and process the results
            foreach (var item in query)
            {
                Console.WriteLine($"OrderID: {item.OrderID}, ProductID: {item.ProductID}, UnitPrice: {item.UnitPrice}");
            }


        }




    }





}

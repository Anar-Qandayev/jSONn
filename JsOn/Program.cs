//using File_Stream.Models;
using Newtonsoft.Json;
using JsOn.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
//using Xml2CSharp;
namespace JsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toys car = new Toys { Id = 1, Name = "MigMig", Price = 6.50 };
            //Toys bus = new Toys { Id = 2, Name = "Halley", Price = 10.50 };
            //Toys doll = new Toys { Id = 3, Name = "Polesie", Price = 12.70 };
            //OrderItem item1 = new OrderItem { Id = 1, Toys = car, Count = 1, TotalPrice = car.Price * 1 };
            //OrderItem item2 = new OrderItem { Id = 2, Toys = bus, Count = 2, TotalPrice = bus.Price * 2 };
            //OrderItem item3 = new OrderItem { Id = 3, Toys = doll, Count = 4, TotalPrice = doll.Price * 4 };
            //OrderItem item4 = new OrderItem { Id = 4, Toys = bus, Count = 1, TotalPrice = bus.Price * 1 };
            //List<OrderItem> orderItems1 = new List<OrderItem>();
            //orderItems1.Add(item1);
            //orderItems1.Add(item3);
            //List<OrderItem> orderItems2 = new List<OrderItem>();
            //orderItems2.Add(item2);
            //orderItems2.Add(item4);
            //Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            //Order order2 = new Order { Id = 2, OrderItems = orderItems2 };
            //var jsonObj = JsonConvert.SerializeObject(order1);
            //Console.WriteLine(jsonObj);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\ibm\source\repos\JsOn\JsOn\File\json1.json"))
            //{
            //    sw.WriteLine(jsonObj);
            //}
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\ibm\source\repos\JsOn\JsOn\File\json1.json"))
            {
                result = sr.ReadToEnd();
            }
            Order o1 = JsonConvert.DeserializeObject<Order>(result);
            Console.WriteLine(o1.OrderItems[0].Toys.Name);
        }
    }
}

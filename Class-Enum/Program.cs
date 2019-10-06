using System;
using System.Globalization;
using System.Collections.Generic;
using CursoProg.Entities;
using CursoProg.Entities.Enums;

namespace CursoProg
{
    class Program 
    {
        static void Main(string[] args) //Main
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }      

    }

}



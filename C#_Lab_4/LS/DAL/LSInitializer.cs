using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LS.Models;

namespace LS.DAL
{
    public class LSInitializer : DropCreateDatabaseIfModelChanges<LSContext>
    {
        protected override void Seed(LSContext context)
        {
            var worker = new List<Worker>
            {
                new Worker { Name = "Алексей", Position = "Менеджер", Salary = 3000 },
                new Worker { Name = "Елена", Position = "Продавец", Salary = 2500 }
            };
            worker.ForEach(s => context.Workers.Add(s));
            context.SaveChanges();

            var car = new List<Car>
            {
                new Car { Brand = "Toyota", Model = "Camry", Color = "Black", Year = 2020, Price = 25000 },
                new Car { Brand = "Honda", Model = "Civic", Color = "White", Year = 2019, Price = 22000 }
            };
            car.ForEach(s => context.Cars.Add(s));
            context.SaveChanges();

            var service = new List<Service>
            {
                new Service { Name = "Замена масла", Cost = 50, WorkerId = 1 },
                new Service { Name = "Замена тормозных колодок", Cost = 100, WorkerId = 2 }
            };
            service.ForEach(s => context.Services.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order { Date = new DateTime(2024, 01, 20, 19, 00, 00), Status = "ready", ClientId = 1, CarId = 2 },
                new Order { Date = new DateTime(2024, 02, 02, 15, 30, 00), Status = "working", ClientId = 2, CarId = 1 }
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
            orders[0].Workers.Add(worker[0]);
            //order1.Workers.Add(worker2);
            //order2.Workers.Add(worker1);
            //order2.Workers.Add(worker2);

            var clients = new List<Client>
            {
                new Client { ClientId = 1, Name = "Иван Иванов", Phone = "1234567890", Email = "ivan@example.com" },
                new Client { ClientId = 2, Name = "Петр Петров", Phone = "0987654321", Email = "petr@example.com" }
            };

            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();
        }
    }

}
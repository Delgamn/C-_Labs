using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LS.Models;



namespace LS.DAL
{
    public class LSContext : DbContext
    {
        // Конструктор, указывающий строку подключения к базе данных
        public LSContext() : base("LSContext")
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Описание связи между таблицами Клиент и Заказ (один-к-одному)
            //modelBuilder.Entity<Order>()
            //    .HasRequired(o => o.Client)
            //    .WithOptional(c => c.Order)
            //    .Map(m => m.MapKey("ClientId"));
            modelBuilder.Entity<Client>()
                .HasKey(c => c.ClientId);

            modelBuilder.Entity<Order>()
                .HasOptional(c => c.Client)
                .WithOptionalDependent(o => o.Order);
            //.WillCascadeOnDelete(true);

            // Описание связи между таблицами Машина и Заказ (многие-к-одному)
            //modelBuilder.Entity<Car>()
            //    .HasMany(o => o.Orders)
            //    .WithRequired(c => c.Car)
            //    .WillCascadeOnDelete(true);

            modelBuilder.Entity<Order>()
                .HasRequired(o => o.Car)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CarId)
                .WillCascadeOnDelete(true);

            // Описание связи между таблицами Заказ и Работник (многие-ко-многим)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Workers)
                .WithMany(w => w.Orders)
                .Map(m =>
                {
                    m.ToTable("OrderWorkers");
                    m.MapLeftKey("OrderId");
                    m.MapRightKey("WorkerId");
                });

            // Описание связи между таблицами Работник и Обслуживание (один-ко-многим)
            modelBuilder.Entity<Service>()
                .HasRequired(s => s.Worker)
                .WithMany(w => w.Services)
                .HasForeignKey(s => s.WorkerId)
                .WillCascadeOnDelete(true);
            //modelBuilder.Entity<Worker>()
            //    .HasMany(s => s.Services)
            //    .WithRequired(w => w.Worker)
            //    .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }

    }
}

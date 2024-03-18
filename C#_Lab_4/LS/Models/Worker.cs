using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace LS.Models
{
    public class Worker
    {
        // Первичный ключ
        [Key]
        public int WorkerId { get; set; }

        // Имя работника
        [Required, MinLength(2), MaxLength(20)]
        public string Name { get; set; }

        // Должность работника
        [Required, MinLength(2), MaxLength(20)]
        public string Position { get; set; }

        // Зарплата работника
        [Required]
        public decimal Salary { get; set; }

        // Связь многие-ко-многим с таблицей Заказ
        public ICollection<Order> Orders { get; set; }

        // Связь один-ко-многим с таблицей Обслуживание
        public ICollection<Service> Services { get; set; }
    }
}
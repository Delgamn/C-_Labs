using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LS.Models
{
    public class Order
    {
        // Первичный ключ
        [Key]
        public int OrderId { get; set; }

        // Дата заказа
        [Required]
        public DateTime Date { get; set; }

        // Статус заказа
        [Required, MinLength(2), MaxLength(20)]
        public string Status { get; set; }

        // Внешний ключ для таблицы Клиент
        public int ClientId { get; set; }

        // Связь один-к-одному с таблицей Клиент
        public virtual Client Client { get; set; }

        // Внешний ключ для таблицы Машина
        public int CarId { get; set; }

        // Связь один-ко-многим с таблицей Машина
        public Car Car { get; set; }

        // Связь многие-ко-многим с таблицей Работник
        public ICollection<Worker> Workers { get; set; }
    }
}
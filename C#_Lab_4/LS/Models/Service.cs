using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LS.Models
{
    public class Service
    {
        // Первичный ключ
        [Key]
        public int ServiceId { get; set; }

        // Название услуги
        [Required, MinLength(2)]
        public string Name { get; set; }

        // Стоимость услуги
        [Required]
        public decimal Cost { get; set; }

        // Внешний ключ для таблицы Работник
        
        public int WorkerId { get; set; }

        // Связь один-ко-многим с таблицей Работник
        public Worker Worker { get; set; }
    }
}
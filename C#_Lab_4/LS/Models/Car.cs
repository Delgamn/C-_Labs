using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LS.Models
{
    public class Car
    {
        // Первичный ключ
        [Key]
        public int CarId { get; set; }

        // Марка машины
        [Required, MinLength(2), MaxLength(20)]
        public string Brand { get; set; }

        // Модель машины
        [Required, MinLength(2), MaxLength(20)] 
        public string Model { get; set; }

        // Цвет машины
        [Required, MinLength(2), MaxLength(20)]
        public string Color { get; set; }

        // Год выпуска машины
        [Required]
        public int Year { get; set; }

        // Цена машины
        [Required]
        public decimal Price { get; set; }

        // Связь один-ко-многим с таблицей Заказ
        public ICollection<Order> Orders { get; set; }
    }
}
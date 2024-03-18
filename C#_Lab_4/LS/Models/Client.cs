using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LS.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientId { get; set; }

        // Имя клиента
        [Required, MinLength(2)]
        public string Name { get; set; }

        // Телефон клиента
        [Required, MinLength(2)]
        public string Phone { get; set; }

        // Электронная почта клиента
        [Required, MinLength(2)]
        public string Email { get; set; }

        // Связь один-к-одному с таблицей Заказ
        public virtual Order Order { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Prato
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Descrição do prato")]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Restaurante Restaurante{ get; set; }
        public int RestauranteID { get; set; }
    }
}
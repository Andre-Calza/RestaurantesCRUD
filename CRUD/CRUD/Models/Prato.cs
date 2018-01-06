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
        [Required]
        [Display(Name = "Preço")]
        [RegularExpression(@"[0-9]{0,10}[,]{0,1}[0-9]{1,2}", ErrorMessage = "Valor inválido")]
        public decimal Preco { get; set; }
        public Restaurante Restaurante{ get; set; }
        [Required]
        [Display(Name = "Descrição do prato")]
        public int RestauranteID { get; set; }
    }
}
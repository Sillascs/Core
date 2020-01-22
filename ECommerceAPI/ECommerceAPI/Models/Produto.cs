using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceAPI.Controllers.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal? Preco{ get; set; }
        [Required]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataModificacao { get; set; }
    }
}

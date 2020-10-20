using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class Lanche
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public Decimal Valor { get; set; }

        public int IngredienteId { get; set; }
    
        public ICollection<LancheIngrediente> LancheIngredientes { get; set; }

        public int ItemId { get; set; }

        public ICollection<Item> Items { get; set; }
    }
} 
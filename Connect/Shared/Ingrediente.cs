using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class Ingrediente
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        public int LancheId { get; set;}

        public ICollection<LancheIngrediente> LancheIngredientes { get; set; }

    }
} 
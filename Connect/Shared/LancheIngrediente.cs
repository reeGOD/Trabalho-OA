using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Connect.Shared
{
    public class LancheIngrediente
    {
        public int Id { get; set; }

        public int LancheId { get; set; }

        public Lanche Lanche { get; set; }

        public int IngredienteId { get; set; }

        public Ingrediente Ingrediente { get; set; }
    }
}    
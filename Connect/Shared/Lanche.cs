using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Connect.Shared
{
    public class Lanche
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Valor { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Connect.Shared
{
    public class Endereco
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CEP { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public int Numero { get; set; }
        
        [Required]
        public string Cidade { get; set; }
        
        [Required]
        public string Estado { get; set; }

        public User User { get; set; }
    }
}

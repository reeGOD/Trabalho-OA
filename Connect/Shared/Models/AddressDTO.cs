using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class AddressDTO
    {

        public int AddressId { get; set; }

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

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
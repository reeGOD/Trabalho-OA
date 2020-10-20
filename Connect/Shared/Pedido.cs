using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal ValorTotal { get; set; }
        public int ItemId { get; set; }

        public ICollection<Item> Item { get; set; }
    }
}

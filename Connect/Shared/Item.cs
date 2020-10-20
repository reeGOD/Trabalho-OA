using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Connect.Shared
{
    public class Item
    {
        public int Id { get; set; }
        
        public int LancheId { get; set; }

        public Lanche Lanche { get; set; }

        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }
    }
}

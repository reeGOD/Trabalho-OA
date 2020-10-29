using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace Connect.Shared
{
    public class Order
    {
        public int OrderId { get; set; }

        public User User { get; set; }

        public DateTime DateOrder { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}


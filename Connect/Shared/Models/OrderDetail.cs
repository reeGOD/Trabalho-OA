using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class OrderDetail
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int SandwichId { get; set; }

        public Sandwich Sandwich { get; set; }

        public int Amount { get; set; }

    }
}
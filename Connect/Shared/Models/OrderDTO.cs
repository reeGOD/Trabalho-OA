using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class OrderDTO
    {
        public string CategoryId { get; set; }

        public string SandwichId { get; set; }

        public int Amount { get; set; }

    }
}    
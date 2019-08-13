using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sourcer
{
    //ord_bah1
    public class Order
    {
        [Key]
        public string cus_nbr { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Grocery2Go.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
       

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }


        public ICollection<ShoppingCartItem> ShoppingCartList { get; set; }

      

    }
}
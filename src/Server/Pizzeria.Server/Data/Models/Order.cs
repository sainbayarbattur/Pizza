﻿namespace Pizzeria.Server.Data.Models
{
    using System.Collections.Generic;
    using Common;

    public class Order : Entity
    {
        public int Id { get; set; }
        
        public string UserId { get; set; }

        public PizzeriaUser User { get; set; }

        public ICollection<OrderPizza> Pizzas { get; } = new HashSet<OrderPizza>();
    }
}

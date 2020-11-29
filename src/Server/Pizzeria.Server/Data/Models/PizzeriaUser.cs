﻿namespace Pizzeria.Server.Data.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class PizzeriaUser : IdentityUser
    {
        public PizzeriaUser(string email)
            : base(email)
            => this.Email = email;

        public ICollection<Order> Orders { get; } = new HashSet<Order>();
    }
}
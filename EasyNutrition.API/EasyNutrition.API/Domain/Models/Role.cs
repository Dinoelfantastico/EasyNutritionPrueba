﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyNutrition.API.Domain.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<User> Users { get; set; } = new List<User>();

    }
}

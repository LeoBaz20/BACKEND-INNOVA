﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Plataforma
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Rol> Roles { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uniart.Entities
{
    public class Estilo:EntityBase
    {
        [Required]
        [StringLength(64)]
        public string Nombre { get; set; }
    }
}

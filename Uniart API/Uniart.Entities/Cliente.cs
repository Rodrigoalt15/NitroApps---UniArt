﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uniart.Entities
{
    public class Cliente:EntityBase
    {
        public int Cuenta_Usuario_id { get; set; }
        public Cuenta_Usuario Cuenta_Usuario { get; set; }

        [Required]
        public DateTime fecha_registro { get; set; }

        [Required]
        [StringLength(255)]
        public string localizacion { get; set; }


    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_de_Prestamo.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Cedula { get; set; }
        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        [Required]
        public decimal Salario { get; set; }

        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
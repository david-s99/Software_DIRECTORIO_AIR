﻿using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class FormLogin
    {
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Contrasenia { get; set; }
        
    }
}
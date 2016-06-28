﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Client
    {
        public int ID { get; set; }
        [Display(Name="First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This Last Name is required")]
        public string Apellido { get; set; }

        public DateTime DateCreation { get; set; }
    }
}

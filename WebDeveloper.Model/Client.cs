﻿using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Client
    {
        [Display(Name = "Client_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }

        [Display(Name="Client_Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This Last Name is required")]
        public string Apellido { get; set; }

        public DateTime? DateCreation { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelloMVC.Models
{
    public class Customer
    {
        public string Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage="Your string is too long!!")]
        [DisplayName("Enter Your Name")]
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}
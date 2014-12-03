﻿using System.ComponentModel.DataAnnotations;
 

namespace Portfolio.Models
{
    public class ContactViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string From { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }

}
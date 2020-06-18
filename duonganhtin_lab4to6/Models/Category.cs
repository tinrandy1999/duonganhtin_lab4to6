﻿using System.ComponentModel.DataAnnotations;

namespace duonganhtin_lab4to6.Models
{
    public class Category
    {
            public byte Id { get; set; }
            [Required]
            [StringLength(255)]
            public string Name { get; set; }
    }
}
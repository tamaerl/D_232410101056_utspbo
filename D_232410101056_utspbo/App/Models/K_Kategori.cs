﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_232410101056_utspbo.App.Models
{
    public class K_Kategori
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama_kategori { get; set; }
    }
}
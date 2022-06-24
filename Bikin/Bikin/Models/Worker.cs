using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bikin.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        
        public string Fullname { get; set; }
        [Required]
        [MaxLength(40)]
        public string Position { get; set; }
        [Required]
        [MaxLength(70)]
        public string Icon { get; set; }
        public string IconUrl { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; } 

    }
}

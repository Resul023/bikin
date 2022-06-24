using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bikin.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]
        [MaxLength(80)]
        public string Desc { get; set; }
    }
}

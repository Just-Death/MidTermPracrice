using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidTermPracrice.Models
{
    public class Interpolate
    {
        //three required fields
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        //fields t0 calculate them
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public int ResultOfInterpolation { get; set; }
        
    }
}

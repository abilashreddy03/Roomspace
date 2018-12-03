using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomonespace.Models
{
    public class Space
    {
        
            [Required]
            public int Id { get; set; }
            [Required]
            public string Room { get; set; }
            public string Name { get; set; }
            [Required]
            public string Team { get; set; }
            [Required]
            public string StartTime { get; set; }
            [Required]
            public string EndTime { get; set; }
            [Required]
            public string Available { get; set; }
        }
    
    }

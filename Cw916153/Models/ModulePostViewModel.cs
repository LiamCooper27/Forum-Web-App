using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cw916153.Models
{
    public class ModulePostViewModel
    {
        public Module Module { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }

        [Required]
        [MinLength(2), MaxLength(30)]
        public string Title { get; set; }

        [Required]
        [MinLength(2), MaxLength(500)]
        public string Content { get; set; }

        public int ModuleId { get; set; }

    }
}
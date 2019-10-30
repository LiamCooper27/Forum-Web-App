using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cw916153.Models
{
    public class Post
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(30)]
        public string Title { get; set; }

        [Required]
        [MinLength(2), MaxLength(500)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
        public string User { get; set; }

    }
}
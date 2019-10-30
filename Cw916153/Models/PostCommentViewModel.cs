using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cw916153.Models
{
    public class PostCommentViewModel
    {
        public Post Post { get; set; }
        public List<Comment> Comments { get; set; }

        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(150)]
        public string Content { get; set; }

        [Display(Name = "Anonymous")]
        public bool IsAnon { get; set; }

        public int PostId { get; set; }
        public Module Module { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cw916153.Models
{
    public class Comment
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(150)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        [Display(Name="Anonymous")]
        public bool IsAnon { get; set; }

        public string User { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
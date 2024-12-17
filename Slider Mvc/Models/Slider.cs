using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slider_Mvc.Models
{
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sliderId { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public bool Status { set; get; }

        [Required]
        public string FilePath { set; get; }

        //for single file
        //public HttpPostedFile File { set; get; }

        //for multiple files (including single file)
        [NotMapped]
        public HttpFileCollectionBase Files { set; get; }

    }
}
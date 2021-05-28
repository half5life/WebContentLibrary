using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebContentLibrary.Models
{
    public class FileExtension
    {
        public int Id { get; set; }

        [Display(Name = "Формат расширения")]
        public string NameExt { get; set; }
    }
}
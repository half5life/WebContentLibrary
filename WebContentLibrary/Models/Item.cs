using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebContentLibrary.Models
{
    public class Item
    {
        public int Id { get; set; } 
        public string User { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public List<string> Files { get; set; }

        [Display(Name = "Теги")]
        public List<string> Tags { get; set; }
    }
}
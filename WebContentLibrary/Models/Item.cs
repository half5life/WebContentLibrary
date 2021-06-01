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

        [Display(Name = "Изображения")]
        public string Images { get; set; }

        [Display(Name = "Архив")]
        public string File { get; set; }

        [Display(Name = "Теги")]
        public string Tags { get; set; }

        [Display(Name = "Расширение файлов")]
        public string Extensions { get; set; }
    }
}
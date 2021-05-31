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

        [Required]
        [Display(Name = "Изображения")]
        public List<string> Images { get; set; }

        [Required]
        [Display(Name = "Архив")]
        public string File { get; set; }

        [Display(Name = "Теги")]
        public List<string> Tags { get; set; }

        [Required]
        [Display(Name = "Расширение файлов")]
        public List<FileExtension> Extensions { get; set; }
        public Item()
        {
            Images = new List<string>();
            Extensions = new List<FileExtension>();
        }
    }
}
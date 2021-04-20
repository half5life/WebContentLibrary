using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebContentLibrary.Models
{
    public class Item
    {
        public int Id { get; set; }
        //public string? UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public List<string> Files { get; set; }
        public List<string> Tags { get; set; }
    }
}
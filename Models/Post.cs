using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int? BlogId { get; set; } // Optional foreign key property
        public Blog? Blog { get; set; } =null;// Optional reference navigation to principal


    }
}
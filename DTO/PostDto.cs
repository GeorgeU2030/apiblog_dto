using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DTO
{
    public class PostDto
    {
        public int Id { get; set; }
        public string? Text { get; set; }
    }
}
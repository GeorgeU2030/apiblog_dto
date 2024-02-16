using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DTO
{
    public class BlogDTO
    {
    public int Id { get; set; }
    public string? Name { get; set; }
    public required List<PostDto> Posts { get; set; }
    }
}

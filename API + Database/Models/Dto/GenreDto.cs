using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___Database.Models.Dto
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class AddGenreDto
    {
        public string Name { get; set; }
    }
}

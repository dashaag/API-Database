using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___Database.Models.Dto
{
    public class FilmDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        /*Navigation Properties*/
        public string GenreName { get; set; }
        public int GenreId { get; set; }
    }

    public class AddFilmDto
    {
        public string Name { get; set; }
        public int Year { get; set; }

        /*Navigation Properties*/
        public string GenreName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___Database.Models.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        /*Navigation Properties*/
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}

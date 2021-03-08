using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API___Database.Models.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}

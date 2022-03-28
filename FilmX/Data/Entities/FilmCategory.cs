using System.Collections.Generic;

namespace FilmX.Data.Entities
{
    public class FilmCategory:CommonEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; }
    }
}

using FilmX.Enums;

namespace FilmX.Data.Entities
{
    public class CostTicket : CommonEntity
    {
        public int Id { get; set; }
        public TypeFilm TypeFilm { get; set; }  
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

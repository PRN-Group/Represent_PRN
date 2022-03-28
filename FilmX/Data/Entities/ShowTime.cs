using FilmX.Enums;
using System;

namespace FilmX.Data.Entities
{
    public class ShowTime : CommonEntity
    {
        public int Id { get; set; }
        public DateTime TimeShow { get; set; }
        public int FilmId { get; set; }
        public int RoomId { get; set; }
        public Film Film { get; set; }
        public Room Room { get; set; }
        public TypeFilm TypeFilm { get; set; } = TypeFilm.T2D;
        public double Price { get; set; }
        
    }
}

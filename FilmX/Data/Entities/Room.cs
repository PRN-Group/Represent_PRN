using System.Collections.Generic;

namespace FilmX.Data.Entities
{
    public class Room : CommonEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AvailableSeats { get; set; } = 40;
    }
}

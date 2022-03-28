using FilmX.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace FilmX.Data.Entities
{
    public class Seat : CommonEntity
    {
        public int Id { get; set; }
        public int Location { get; set; }
        public bool IsEmpty { get; set; } = true;
        public int RoomId { get; set; }
        public int ShowTimeId { get; set; }
        public Room Room { get; set; }
        public ShowTime ShowTime { get; set; }
    }
}

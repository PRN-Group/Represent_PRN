using System;
using System.Collections.Generic;

namespace FilmX.Data.Entities
{
    public class Film : CommonEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime PublicDate { get; set; }
        public string Country { get; set; }
        public string Producer { get; set; }
        public string Directors { get; set; }
        public bool Status { get; set; }
        public int NumOfViews { get; set; } = 0;
        public int TotalVote { get; set; } = 0;
        public int NumberOfVote { get; set; } = 0;
        public int LimitAge { get; set; } = 0;
        public int CategoryId { get; set; }
        public FilmCategory Category { get; set; }
        public List<ShowTime> ShowTimes { get; set; }
        public string ImagePath { get; set; }
    }
}

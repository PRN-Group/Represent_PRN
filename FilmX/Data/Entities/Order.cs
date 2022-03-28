using System;

namespace FilmX.Data.Entities
{
    public class Order:CommonEntity
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public User User { get; set; }
        public bool isCompleted { get; set; } 
        public double TotalPrice { get; set; }
    }
}

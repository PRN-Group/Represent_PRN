namespace FilmX.Data.Entities
{
    public class OrderDetails : CommonEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ShowTimeId { get; set; }
        public int SeatId { get; set; }
        public Order Order { get; set; }
        public ShowTime ShowTime { get; set; }
        public Seat Seat { get; set; }
    }
}

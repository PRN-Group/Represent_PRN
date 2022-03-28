using System;

namespace FilmX.Data.Entities
{
    public class CommonEntity
    {
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }

}

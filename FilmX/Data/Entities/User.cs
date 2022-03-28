using FilmX.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmX.Data.Entities
{
    public class User : IdentityUser<int>
    {
        //public string Id { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        
        public int RoleId { get; set; }
        public int YearOfBirth { get; set; }

    }
}

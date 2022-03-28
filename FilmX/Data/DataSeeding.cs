using FilmX.Data.Entities;
using FilmX.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FilmX.Data
{
    public static class DataSeeding
    {
        public static void Seeding(ModelBuilder modelBuilder)
        {
            #region Seeding Room
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 1,
                    Name = "R1"
                },
                new Room
                {
                    Id = 2,
                    Name = "R2"
                },
                new Room
                {
                    Id = 3,
                    Name = "R3"
                },
                new Room
                {
                    Id = 4,
                    Name = "R4"
                }
            );
            #endregion
            #region Seeding Category

            modelBuilder.Entity<FilmCategory>().HasData(
                new FilmCategory
                {
                    Id = 1,
                    CreatedOn = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Chelsea"
                },
                new FilmCategory
                {
                    Id = 2,
                    CreatedOn = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Liverpool"
                },
                new FilmCategory
                {
                    Id = 3,
                    CreatedOn = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Real"
                });
            #endregion
            #region Seeding TypeFilm
            modelBuilder.Entity<CostTicket>().HasData(
                new CostTicket
                {
                    Id = 1,
                    TypeFilm = TypeFilm.T2D,
                    Name = "Film 2D",
                    Price = 10
                },
                new CostTicket
                {
                    Id = 2,
                    TypeFilm = TypeFilm.T3D,
                    Name = "Film 3D",
                    Price = 15
                }
                );
            #endregion
            #region Seeding Film
            modelBuilder.Entity<Film>().HasData(
                new Film
                {
                    Id = 1,
                    Country = "Viet Nam",
                    CreatedOn = System.DateTime.Now,
                    Directors = "Ngoc Hoi",
                    Duration = 150,
                    IsDeleted = false,
                    LimitAge = 18,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Bat Man",
                    NumberOfVote = 5,
                    NumOfViews = 1200,
                    Producer = "Joker",
                    PublicDate = System.DateTime.Now,
                    Status = true,
                    TotalVote = 5,
                    CategoryId = 1,
                    ImagePath = "batman.jpg"
                },
                new Film
                {
                    Id = 2,
                    Country = "Viet Nam",
                    CreatedOn = System.DateTime.Now,
                    Directors = "Illa Oi",
                    Duration = 150,
                    IsDeleted = false,
                    LimitAge = 18,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Spiderman",
                    NumberOfVote = 5,
                    NumOfViews = 1200,
                    Producer = "Ngoc Hoi",
                    PublicDate = System.DateTime.Now,
                    Status = true,
                    TotalVote = 5,
                    CategoryId = 1,
                    ImagePath = "spiderman.jpg"
                },
                new Film
                {
                    Id = 3,
                    Country = "Viet Nam",
                    CreatedOn = System.DateTime.Now,
                    Directors = "Missfortune",
                    Duration = 150,
                    IsDeleted = false,
                    LimitAge = 18,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Supperman",
                    NumberOfVote = 5,
                    NumOfViews = 1200,
                    Producer = "Vi",
                    PublicDate = System.DateTime.Now,
                    Status = true,
                    TotalVote = 5,
                    CategoryId = 1,
                    ImagePath = "supper.jpg"
                },
                new Film
                {
                    Id = 4,
                    Country = "Viet Nam",
                    CreatedOn = System.DateTime.Now,
                    Directors = "Jayce",
                    Duration = 150,
                    IsDeleted = false,
                    LimitAge = 18,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Thor Ranarok",
                    NumberOfVote = 5,
                    NumOfViews = 1200,
                    Producer = "Vi",
                    PublicDate = System.DateTime.Now,
                    Status = true,
                    TotalVote = 5,
                    CategoryId = 1,
                    ImagePath = "thor.jpg"
                },
                new Film
                {
                    Id = 5,
                    Country = "Viet Nam",
                    CreatedOn = System.DateTime.Now,
                    Directors = "Olivia Giroud",
                    Duration = 150,
                    IsDeleted = false,
                    LimitAge = 18,
                    ModifiedOn = System.DateTime.Now,
                    Name = "Ironman 3",
                    NumberOfVote = 5,
                    NumOfViews = 1200,
                    Producer = "Gumayusy",
                    PublicDate = System.DateTime.Now,
                    Status = true,
                    TotalVote = 5,
                    CategoryId = 1,
                    ImagePath = "iron.jpg"
                }
            );
            #endregion
            #region Seeding ShowTime
            modelBuilder.Entity<ShowTime>().HasData(
                new ShowTime {
                    Id = 1,
                    FilmId = 3,
                    RoomId = 1,
                    TimeShow = Convert.ToDateTime("1/1/2020 14:00:00"),
                },
                new ShowTime
                {
                    Id = 2,
                    FilmId = 3,
                    RoomId = 1,
                    TimeShow = Convert.ToDateTime("1/1/2020 18:00:00"),
                });
            #endregion
            #region Seeding Role
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, Name = "Admin" },
                new UserRole { Id = 2, Name = "Customer" }
                );
            #endregion
            #region Seeding User
            #endregion
            #region Seeding Seats
            var listSeat = new List<Seat>();
            for(int i=1;i<=20;++i)
            {
                listSeat.Add(new Seat
                {
                    Id = i,
                    Location = i,
                    RoomId = 1,
                    IsEmpty = false
                }) ;
            }
            modelBuilder.Entity<Seat>().HasData(listSeat);
            #endregion

        }
    }
}

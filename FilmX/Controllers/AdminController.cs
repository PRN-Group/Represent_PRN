using Microsoft.AspNetCore.Mvc;
using FilmX.Data;
using FilmX.Data.Entities;
using FilmX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace FilmX.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;

        public AdminController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var listFilm = _context.films.ToList();
            ViewBag.Categories = _context.filmCategories.ToList();
            return View(listFilm);

        }

        [HttpPost]
        public IActionResult Index(int CategoryID)
        {
            ViewBag.SelectedID = CategoryID;
            ViewBag.Categories = _context.filmCategories.ToList();

            var films = _context.films.ToList();
            if (CategoryID != 0)
            {
                films = (from p in _context.films
                         where p.CategoryId == CategoryID
                         select p).ToList();

            }
            return View(films);

        }


        public IActionResult FilmList()
        {
            var listFilm = _context.films.ToList();
            ViewBag.Categories = _context.filmCategories.ToList();
            return View(listFilm);

        }

        [HttpPost]
        public IActionResult FilmList(int CategoryID)
        {
            ViewBag.SelectedID = CategoryID;
            ViewBag.Categories = _context.filmCategories.ToList();

            var films = _context.films.ToList();
            if (CategoryID != 0)
            {
                films = (from p in _context.films
                         where p.CategoryId == CategoryID
                         select p).ToList();
            }
            return View(films);

        }


        [HttpPost]
        public IActionResult SearchFilm(string searchName)
        {

            var films = _context.films.ToList();
            if (searchName != null)
            {
                films = (from p in _context.films
                         where (p.Name.Contains(searchName))
                         select p).ToList();
            }
            ViewBag.Categories = _context.filmCategories.ToList();
            return View(films);
        }


        public IActionResult Add()
        {
            ViewBag.Categories = _context.filmCategories.ToList();
            return View("Add");
        }
        [HttpPost]
        public IActionResult Add(Film film)
        {
            film.NumberOfVote = 0;
            film.TotalVote = 0;
            film.CreatedOn = DateTime.Now;
            film.ModifiedOn = DateTime.Now;
            film.IsDeleted = false;

            _context.films.Add(film);
            _context.SaveChanges();
            var listFilm = _context.films.ToList();


            ViewBag.Categories = _context.filmCategories.ToList();

            return View("FilmList", listFilm);
        }

        public IActionResult Edit(int id)
        {
            var film = _context.films.Find(id);
            ViewBag.Categories = _context.filmCategories.ToList();
            return View("Edit", film);
        }


        [HttpPost]
        public IActionResult Edit(Film film)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Categories = _context.filmCategories.ToList();
                _context.Update(film);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("FilmList");
        }


        public IActionResult Delete(int id)
        {
            var film = _context.films.Find(id);
            //_context.films.Remove(film);
            film.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction("FilmList");
        }
        //#################################CategoryFilm##################################################
        public IActionResult categoryFilm()
        {
            var listCategory = _context.filmCategories.ToList();
            ViewBag.CategoriesFilm = _context.filmCategories.ToList();
            return View(listCategory);
        }


        [HttpPost]
        public IActionResult categoryFilm(int CategoryID)
        {
            ViewBag.SelectedID = CategoryID;
            ViewBag.CategoriesFilm = _context.filmCategories.ToList();

            var category = _context.filmCategories.ToList();
            if (CategoryID != 0)
            {
                category = (from p in _context.filmCategories
                            where p.Id == CategoryID
                            select p).ToList();

            }
            return View(category);
        }

        public IActionResult addCategoryFilm()
        {
            return View("addCategoryFilm");
        }
        [HttpPost]
        public IActionResult addCategoryFilm(FilmCategory filmCategory)
        {

            filmCategory.IsDeleted = false;

            _context.filmCategories.Add(filmCategory);
            _context.SaveChanges();
            var listCategory = _context.filmCategories.ToList();

            return RedirectToAction("categoryFilm", listCategory);
        }

        public IActionResult editCategoryFilm(int id)
        {
            var filmCategory = _context.filmCategories.Find(id);
            return View("editCategoryFilm", filmCategory);
        }


        [HttpPost]
        public IActionResult editCategoryFilm(FilmCategory filmCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Update(filmCategory);
                _context.SaveChanges();
                return RedirectToAction("categoryFilm");
            }
            var listCategory = _context.filmCategories.ToList();
            return RedirectToAction("categoryFilm", listCategory);
        }

        public IActionResult deleteCategoryFilm(int id)
        {

            var filmCategory = _context.filmCategories.Find(id);
            //_context.filmCategories.Remove(filmCategory);
            filmCategory.IsDeleted = true;
            _context.SaveChanges();
            var listCategory = _context.filmCategories.ToList();
            return RedirectToAction("categoryFilm", listCategory);
        }




        //#################################USSER##################################################

        public IActionResult UserList()
        {
            var userList = _context.Users.ToList();
            ViewBag.Role = _context.Roles.ToList();
            return View(userList);
        }
        [HttpPost]
        public IActionResult UserList(string searchName)
        {

            var user = _context.Users.ToList();
            if (searchName != null)
            {
                user = (from p in _context.Users
                        where (p.FullName.Contains(searchName))
                        select p).ToList();
            }

            ViewBag.Role = _context.Roles.ToList();
            return View(user);
        }

        public IActionResult AddUser()
        {
            ViewBag.Role = _context.Roles.ToList();
            return View("AddUser");
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            user.EmailConfirmed = false;
            user.PhoneNumberConfirmed = false;
            user.TwoFactorEnabled = false;
            user.LockoutEnabled = false;
            user.AccessFailedCount = 0;
            //user.
            _context.Users.Add(user);
            _context.SaveChanges();
            var userList = _context.Users.ToList();
            ViewBag.Role = _context.Roles.ToList();
            return RedirectToAction("UserList", userList);
        }

        public IActionResult EditUser(int id)
        {
            var user = _context.Users.Find(id);
            ViewBag.Role = _context.Roles.ToList();
            return View("EditUser", user);
        }


        [HttpPost]
        public IActionResult EditUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Update(user);
                _context.SaveChanges();
                return RedirectToAction("UserList");
            }
            var userList = _context.Users.ToList();
            ViewBag.Role = _context.Roles.ToList();
            return RedirectToAction("UserList", userList);
        }

        public IActionResult deleteUser(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();

            var listUser = _context.Users.ToList();
            ViewBag.Role = _context.Roles.ToList();
            return RedirectToAction("UserList", listUser);
        }


        public IActionResult Dashboard()
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 28; i >= 0; i -= 7)
            {
                dates.Add(DateTime.Now.AddDays(-i));
            }
            int[] totalPrice = new int[dates.Count];
            totalPrice[0] = 0;
            totalPrice[1] = getTotalPriceInDuration(dates[0], dates[1]);
            totalPrice[2] = getTotalPriceInDuration(dates[1], dates[2]);
            totalPrice[3] = getTotalPriceInDuration(dates[2], dates[3]);
            totalPrice[4] = getTotalPriceInDuration(dates[3], dates[4]);
            ViewBag.TotalPrice = totalPrice;
            List<string> _dates = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                _dates.Add(dates[i].ToString("MM/dd/yyyy"));
            }
            ViewBag.Dates = _dates;
            return View("Chart");
        }

        public int getTotalPriceInDuration(DateTime startDate, DateTime endDate)
        {
            SqlConnection connection = new SqlConnection("Server = localhost; Database = FilmX_DataBase; Trusted_Connection = True");
            string sql = "SELECT SUM(TotalPrice) AS Total FROM dbo.orders " +
                "WHERE CreatedOn BETWEEN @start AND @end";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@start", startDate);
            command.Parameters.AddWithValue("@end", endDate);
            try
            {
                connection.Open();
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32("Total");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return 0;
        }
        public IActionResult CostTicketList()
        {
            var listCostTicket = _context.costTickets.ToList();
            return View(listCostTicket);
        }
        [HttpGet]
        public IActionResult addCostTicket()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addCostTicket(CostTicket costTicket)
        {
            costTicket.CreatedOn = DateTime.Now;
            costTicket.ModifiedOn = DateTime.Now;
            costTicket.IsDeleted = false;
            costTicket.TypeFilm = _context.costTickets.OrderBy(s => s.Id).Last().TypeFilm + 1;
            _context.costTickets.Add(costTicket);
            _context.SaveChanges();

            var listCostTicket = _context.costTickets.ToList();
            return View("CostTicketList", listCostTicket);
        }
        [HttpGet]
        public IActionResult editCostTicket(int id)
        {
            var costTicket = _context.costTickets.Find(id);
            return View("editCostTicket", costTicket);
        }
        [HttpPost]
        public IActionResult editCostTicket(CostTicket costTicket)
        {
            if (ModelState.IsValid)
            {
                var listShowTime = _context.costTickets.ToList();
                costTicket.ModifiedOn = DateTime.Now;
                _context.costTickets.Update(costTicket);
                _context.SaveChanges();
                return RedirectToAction("CostTicketList", listShowTime);
            }
            var listCostTicket = _context.costTickets.ToList();
            return RedirectToAction("CostTicketList", listCostTicket);
        }
        #region SHOWTIME
        public IActionResult ShowTimeList()
        {
            var listShowTime = _context.showTimes.ToList();
            foreach (var item in listShowTime)
            {
                item.Room = _context.rooms.Find(item.RoomId);
                item.Film = _context.films.Find(item.FilmId);
            }
            return View(listShowTime);
        }
        [HttpGet]
        public IActionResult addShowTime()
        {
            ViewBag.TypeFilms = _context.costTickets.ToList();
            ViewBag.Films = _context.films.ToList();
            ViewBag.Rooms = _context.rooms.ToList();

            return View();
        }
        public bool isValidTime(ShowTime showtime)
        {
            bool isValid = true;
            var showtimes = _context.showTimes.ToList();
            foreach (ShowTime s in showtimes)
            {
                var duration = _context.films.Find(s.FilmId).Duration;
                if (showtime.TimeShow < s.TimeShow.AddMinutes(duration))
                {
                    isValid = false;
                }
                if (showtime.TimeShow < s.TimeShow && showtime.TimeShow.AddMinutes(_context.films.Find(showtime.FilmId).Duration) > s.TimeShow)
                {
                    isValid = false;
                }
            }
            return isValid;
        }
        [HttpPost]
        public IActionResult addShowTime(ShowTime showtime)
        {

            if (isValidTime(showtime))
            {
                showtime.CreatedOn = DateTime.Now;
                showtime.ModifiedOn = DateTime.Now;
                showtime.IsDeleted = false;

                _context.showTimes.Add(showtime);

                // Add 20 empty seats with showtime
                for (int i = 0; i < 20; i++)
                {
                    Seat s = new Seat();
                    s.IsEmpty = false;
                    s.RoomId = showtime.RoomId;
                    s.ModifiedOn = DateTime.Now;
                    s.CreatedOn = DateTime.Now;
                    s.IsEmpty = false;
                    s.ShowTime = showtime;
                    _context.seats.Add(s);
                }

                _context.SaveChanges();

                var listShowTime = _context.showTimes.ToList();
                foreach (var item in listShowTime)
                {
                    item.Room = _context.rooms.Find(item.RoomId);
                    item.Film = _context.films.Find(item.FilmId);
                }
                return View("ShowTimeList", listShowTime);
            }
            ViewBag.Error = "Please check your time!";
            ViewBag.TypeFilms = _context.costTickets.ToList();
            ViewBag.Films = _context.films.ToList();
            ViewBag.Rooms = _context.rooms.ToList();
            return View("addShowTime");
        }

        [HttpGet]
        public IActionResult editShowTime(int id)
        {
            var showTime = _context.showTimes.Find(id);
            ViewBag.TypeFilms = _context.costTickets.ToList();
            ViewBag.Films = _context.films.ToList();
            ViewBag.Rooms = _context.rooms.ToList();
            return View("editShowTime", showTime);
        }

        [HttpPost]
        public IActionResult editShowTime(ShowTime showtime)
        {
            if (ModelState.IsValid && isValidTime(showtime))
            {
                var listShowTime = _context.showTimes.ToList();
                foreach (var item in listShowTime)
                {
                    item.Room = _context.rooms.Find(item.RoomId);
                    item.Film = _context.films.Find(item.FilmId);
                }
                showtime.Room = _context.rooms.Find(showtime.RoomId);
                showtime.Film = _context.films.Find(showtime.FilmId);
                _context.showTimes.Update(showtime);
                _context.SaveChanges();
                return RedirectToAction("ShowTimeList", listShowTime);
            }
            ViewBag.Error = "Please check your time!";
            ViewBag.TypeFilms = _context.costTickets.ToList();
            ViewBag.Films = _context.films.ToList();
            ViewBag.Rooms = _context.rooms.ToList();
            return RedirectToAction("editShowTime", showtime);
        }

        public IActionResult deleteShowTime(int id)
        {
            var listShowTime = _context.showTimes.ToList();
            foreach (var item in listShowTime)
            {
                item.Room = _context.rooms.Find(item.RoomId);
                item.Film = _context.films.Find(item.FilmId);
            }
            var showTime = _context.showTimes.Find(id);
            //_context.films.Remove(film);
            showTime.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction("ShowTimeList", listShowTime);
        }

    }
    #endregion

        
}

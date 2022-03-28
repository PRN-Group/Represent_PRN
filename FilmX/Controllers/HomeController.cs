using FilmX.Data;
using FilmX.Data.Entities;
using FilmX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
namespace FilmX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult filmdetail(int Id)
        {
            var filmdetail = _context.films.Find(Id);
            return View(filmdetail);
        }
        public IActionResult Index()
        {
            var incommingFilm = IncommingFilms();
            var topViews = TopViews();
            ViewBag.IncommingFilm = incommingFilm;
            ViewBag.TopViews = topViews;
            var result = _context.films.Take(5).ToList();
            var test = JsonConvert.SerializeObject(result);
            HttpContext.Session.SetString("list", JsonConvert.SerializeObject(result));
            ViewBag.ListFilms = result;
            ViewBag.Incomming = IncommingFilms();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SelectFilm( int? id)
        {
            if(id == null)
            {
                ViewBag.ListFilms = _context.films.Take(5).ToList();
                return View("~/Views/Home/Index.cshtml");
            }
            var listView = JsonConvert.DeserializeObject<List<Film>>(HttpContext.Session.GetString("list"));
            // Get index of Films
            int idx = 0;
            for (int i = 0; i < listView.Count; i++)
            {
                if(listView[i].Id == id)
                {
                    idx = i;
                    break;
                }
            }
            var temp = listView[2];
            listView[2] = listView[idx];
            listView[idx] = temp;
            HttpContext.Session.SetString("list", JsonConvert.SerializeObject(listView));
            ViewBag.ListFilms = listView;
            ViewBag.Incomming = IncommingFilms();
            return View("~/Views/Home/Index.cshtml");
        }
        public List<Film> IncommingFilms()
        {
            List<Film> list = new List<Film>();
            SqlConnection connection = new SqlConnection("Server = localhost; Database = FilmX_DataBase; Trusted_Connection = True");
            string sql = "SELECT TOP(5) * FROM dbo.films WHERE DATEDIFF(DAY, GETDATE(), CreatedOn) >= -2";
            var command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Film
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Duration = reader.GetInt32("Duration"),
                            PublicDate = reader.GetDateTime("PublicDate"),
                            Country = reader.GetString("Country"),
                            Producer = reader.GetString("Producer"),
                            Directors = reader.GetString("Directors"),
                            Status = reader.GetBoolean("Status"),
                            NumOfViews = reader.GetInt32("NumOfViews"),
                            TotalVote = reader.GetInt32("TotalVote"),
                            NumberOfVote = reader.GetInt32("NumberOfVote"),
                            LimitAge = reader.GetInt32("LimitAge"),
                            ImagePath = reader.GetString("ImagePath"),
                            CategoryId = reader.GetInt32("CategoryId"),
                            ModifiedOn = reader.GetDateTime("ModifiedOn"),
                            CreatedOn = reader.GetDateTime("CreatedOn"),
                            IsDeleted = reader.GetBoolean("IsDeleted")
                        });
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
                //ViewBag.Incomming = list;
            }
            return list;
        }

        public List<Film> TopViews()
        {
            List<Film> list = new List<Film>();
            SqlConnection connection = new SqlConnection("Server = localhost; Database = FilmX_DataBase; Trusted_Connection = True");
            string sql = "SELECT TOP(5)* FROM dbo.films f ORDER BY f.NumOfViews DESC";
            var command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Film
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Duration = reader.GetInt32("Duration"),
                            PublicDate = reader.GetDateTime("PublicDate"),
                            Country = reader.GetString("Country"),
                            Producer = reader.GetString("Producer"),
                            Directors = reader.GetString("Directors"),
                            Status = reader.GetBoolean("Status"),
                            NumOfViews = reader.GetInt32("NumOfViews"),
                            TotalVote = reader.GetInt32("TotalVote"),
                            NumberOfVote = reader.GetInt32("NumberOfVote"),
                            LimitAge = reader.GetInt32("LimitAge"),
                            ImagePath = reader.GetString("ImagePath"),
                            CategoryId = reader.GetInt32("CategoryId"),
                            ModifiedOn = reader.GetDateTime("ModifiedOn"),
                            CreatedOn = reader.GetDateTime("CreatedOn"),
                            IsDeleted = reader.GetBoolean("IsDeleted")
                        });
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
            return list;
        }
    }
}

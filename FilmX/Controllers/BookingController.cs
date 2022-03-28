using FilmX.Data;
using FilmX.Data.Entities;
using FilmX.Models.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FilmX.Controllers
{
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        public BookingController(ILogger<BookingController> logger, ApplicationContext context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Detail(int id)
        {
            var filmdetail = _context.films.Find(id);
            var showTimes = _context.showTimes.Where(showtime => showtime.Film.Id == id).ToList();
            ViewBag.BookingID = id;
            ViewBag.ShowTimes = showTimes;
            var film = _context.films.FirstOrDefault(x => x.Id == id);
            foreach (var showtime in showTimes)
            {
                showtime.Film = film;
            }
            ViewBag.Film = film;
            return View(filmdetail);
        }

        public IActionResult Room(int id)
        {
            var showTime = _context.showTimes.FirstOrDefault(x => x.Id == id);
            //Room room = _context.rooms.FirstOrDefault(x => x.Id == showTime.RoomId);
            var listSeats = _context.seats.Where(x => x.ShowTimeId == showTime.Id).ToList();
            ViewBag.listSeats = listSeats;
            return View(new SeatModel
            {
                Seats = listSeats
            });
        }

        [HttpPost]
        public async Task<IActionResult> Booking(SeatModel seatmodel)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var primaryKey = _context.orders.Add(new Order
            {
                User = user,
                ModifiedOn = DateTime.Now,
                IsDeleted = false,
                CreatedOn = DateTime.Now

            });
            _context.SaveChanges();
            var order = _context.orders.FirstOrDefault(x => x.User == user && x.isCompleted == false);

            var listOrderDetails = new List<OrderDetails>();

            var seat = _context.seats.FirstOrDefault(x => x.Id == seatmodel.Seats[0].Id);
            var showTime = _context.showTimes.FirstOrDefault(x => x.Id == seat.ShowTimeId);
            foreach (var item in _context.seats)
            {
                foreach (var item2 in seatmodel.Seats)
                {
                    if (item.Id == item2.Id)
                    {
                        if (item.IsEmpty == false && item2.IsEmpty == true)
                        {
                           
                            listOrderDetails.Add(new OrderDetails
                            {
                                OrderId = order.Id,
                                SeatId = item2.Id,
                                ShowTimeId = item.ShowTimeId,
                                ModifiedOn = DateTime.UtcNow,
                                IsDeleted = false
                            }) ;
                            
                            order.TotalPrice += (double)showTime.Price;
                        }
                    }
                }
            }
            _context.orders.Update(order);
            _context.orderDetails.AddRange(listOrderDetails);
            _context.SaveChanges();
            return RedirectToAction("Checkout", "Checkout", order);
        }

    }
}

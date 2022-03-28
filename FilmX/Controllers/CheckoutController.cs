using FilmX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using FilmX.Data.Entities;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FilmX.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        public CheckoutController(ILogger<CheckoutController> logger, ApplicationContext context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Checkout(Order order)
        {
            
            var User = await _userManager.GetUserAsync(HttpContext.User);
            
            var OrderDetails = (_context.orderDetails.Where(X => X.Order == order)).ToList();
            foreach (var orderDetails in OrderDetails)
            {
                orderDetails.ShowTime = _context.showTimes.FirstOrDefault();
            }

            List<int> listSeatId = new List<int>();
            
            foreach (var item in OrderDetails)
            {
                //item.Seat.IsEmpty = true; 

                listSeatId.Add(item.SeatId);
            }
            var listSeatUpdate = _context.seats.Where(X => listSeatId.Contains(X.Id)).ToList();
            string listSeat = ""; 
            foreach (var item in listSeatUpdate)
            {
                item.IsEmpty = true;
                listSeat = listSeat + item.Id + ",";
                _context.seats.Update(item);
            }
            _context.SaveChanges(); 
            var o = OrderDetails[0];
            int idShowTime = o.ShowTimeId;
            //var ShowTime = (from st in _context.showTimes
            //                where st.Id == o.ShowTimeId
            //                select st) as ShowTime;
            var ShowTime = _context.showTimes.FirstOrDefault(X => X.Id == idShowTime);

            var Film = _context.films.FirstOrDefault(X => X.Id == ShowTime.FilmId);

            ViewBag.order = order;
            ViewBag.film = Film;
            ViewBag.showTime = ShowTime;
            ViewBag.listSeat = listSeat;
            ViewBag.user = User;
            return View();
        }

        public async Task<IActionResult> UpdateCheckout(int? id)
        {
            //id = 5; 
            var order = _context.orders.Find(id);
            order.isCompleted = true;

            var User = await _userManager.GetUserAsync(HttpContext.User);

            var OrderDetails = (_context.orderDetails.Where(X => X.Order == order)).ToList();
            foreach (var orderDetails in OrderDetails)
            {
                orderDetails.ShowTime = _context.showTimes.FirstOrDefault();
            }

            List<int> listSeatId = new List<int>();

            foreach (var item in OrderDetails)
            {
                //item.Seat.IsEmpty = true; 

                listSeatId.Add(item.SeatId);
            }
            var listSeatUpdate = _context.seats.Where(X => listSeatId.Contains(X.Id)).ToList();
            string listSeat = "";
            foreach (var item in listSeatUpdate)
            {
                item.IsEmpty = true;
                listSeat = listSeat + item.Id + ",";
                _context.seats.Update(item);
            }

            var o = OrderDetails[0];
            int idShowTime = o.ShowTimeId;
            
            var ShowTime = _context.showTimes.FirstOrDefault(X => X.Id == idShowTime);

            var Film = _context.films.FirstOrDefault(X => X.Id == ShowTime.FilmId);
            _context.SaveChanges();
            var start = ShowTime.TimeShow.ToString("HH:mm");
            
            
            //-------------------------------------------------------------------------------------------

            string from = "vutrihien20012001@gmail.com"; //To address    
            string to = User.Email; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "You has been booking:\n";
            mailbody = mailbody + "Your Film: " + Film.Name + "\n";
            mailbody = mailbody + "Your Seat: " + listSeat + "\n";
            mailbody = mailbody + "Your Time: Start " + ShowTime.TimeShow.ToString("HH:mm") + " Duration " + Film.Duration + "\n";
            mailbody = mailbody + "Date: " + ShowTime.TimeShow.ToString("dd/M/yyyy"); 
            message.Subject = "Confirm To booking cinema";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("vutrihien20012001@gmail.com", "0915659862");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("index", "Home");
        }
    }
}

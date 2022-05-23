using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private ITicketService _ticketService;
        public AdminController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public IActionResult AdminList()
        {
            return View(new RouteTicket()
            {
                Tickets = _ticketService.GetAll()
            });
        }

        public IActionResult CancelTicket(int ticketId)
        {
            var ticket = _ticketService.GetById(ticketId);
            if (ticket != null)
            {
                _ticketService.Delete(ticket);
            }
            return RedirectToAction("AdminList");
        }
    }
}

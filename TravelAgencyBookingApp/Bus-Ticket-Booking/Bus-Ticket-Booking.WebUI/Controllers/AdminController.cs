using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.Entity;
using Bus_Ticket_Booking.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private ITicketService _ticketService;
        private IRouteService _routeService;
        private ICityService _cityService;
        public AdminController(ITicketService ticketService, IRouteService routeService, ICityService cityService)
        {
            _ticketService = ticketService;
            _routeService = routeService;
            _cityService = cityService;
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

        public IActionResult ListRoute()
        {
            return View(new RouteTicket()
            {
                Routes = _routeService.GetAll()
            });
        }
        public IActionResult CreateRoute()
        {
            ViewBag.Routes = _routeService.GetAll();
            var cities = _cityService.GetAll();
            ViewBag.Cities = new SelectList(cities, "CityName", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult CreateRoute(Route route)
        {
            _routeService.Create(route);
            return RedirectToAction("AdminList");
        }

        public IActionResult EditRoute(int id)
        {
            var cities = _cityService.GetAll();
            ViewBag.Cities = new SelectList(cities, "CityName", "CityName");
            var entity = _routeService.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult EditRoute(Route route)
        {
            _routeService.Update(route);
            return RedirectToAction("ListRoute");

        }

        public IActionResult DeleteRoute(int routeId)
        {
            var entity = _routeService.GetById(routeId);
            _routeService.Delete(entity);
            return RedirectToAction("ListRoute");
        }
    }
    
}

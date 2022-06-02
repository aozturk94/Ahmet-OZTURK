using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.Entity;
using Bus_Ticket_Booking.WebUI.Identity;
using Bus_Ticket_Booking.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly IRouteService _routeService;
        private readonly ICityService _cityService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AdminController(ITicketService ticketService, IRouteService routeService, ICityService cityService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _ticketService = ticketService;
            _routeService = routeService;
            _cityService = cityService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(
                    new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        public async Task<ActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditDetails model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/admin/role/" + model.RoleId);
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

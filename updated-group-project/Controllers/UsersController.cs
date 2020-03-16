﻿using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD


using System.Security.Claims;


=======
using System.Security.Claims;
>>>>>>> 3c166aa86432329d58313a5df45ca16fdd32f6b6
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using updated_group_project.Data;
<<<<<<< HEAD


using updated_group_project.Interfaces;


=======
using updated_group_project.Interfaces;
>>>>>>> 3c166aa86432329d58313a5df45ca16fdd32f6b6
using updated_group_project.Models;

namespace updated_group_project.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
        // GET: Users
<<<<<<< HEAD

=======
=======
   
>>>>>>> 3c166aa86432329d58313a5df45ca16fdd32f6b6
        public async Task<IActionResult> GetEvents([FromServices] IEventService EventServices)

        {
            EventObject eventfull = await EventServices.GetEvent();
            return View(eventfull.events.eventArray);
        }
        public async Task<IActionResult> EventDetails([FromServices] IEventService EventService)
        {
            EventObject eventfull = await EventService.SearchId();
            return View(eventfull.events.eventArray);
        }
<<<<<<< HEAD
=======

>>>>>>> 686741d2557f548acfe59541bc7d816bd9a87cd7
>>>>>>> 3c166aa86432329d58313a5df45ca16fdd32f6b6
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.User.Include(u => u.AppUser);
            return View(await applicationDbContext.ToListAsync());
<<<<<<< HEAD
=======

>>>>>>> 686741d2557f548acfe59541bc7d816bd9a87cd7
        }
<<<<<<< HEAD
=======


        

>>>>>>> 3c166aa86432329d58313a5df45ca16fdd32f6b6
        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id, Event[] events)
        {

            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.AppUser)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Age,City,Name,FirstName,LastName,Email,Address,AppUserId")] User user)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
=======

>>>>>>> 686741d2557f548acfe59541bc7d816bd9a87cd7
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                user.AppUserId = userId;
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", user.AppUserId);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", user.AppUserId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Age,City,Name,FirstName,LastName,Email,Address,AppUserId")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", user.AppUserId);
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.AppUser)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
    }
}

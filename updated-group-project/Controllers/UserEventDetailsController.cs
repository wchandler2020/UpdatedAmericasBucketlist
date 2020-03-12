 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using updated_group_project.Data;
using updated_group_project.Interfaces;
using updated_group_project.Models;
using updated_group_project.Services;

namespace updated_group_project.Controllers
{
    public class UserEventDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserEventDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserEventDetails
       
        public async Task<IActionResult> GetEvents([FromServices] IEventService EventServices)
        {
            EventObject eventfull = await EventServices.GetEvent();
            return View(eventfull.events.eventArray);
        }

        //public async Task<IActionResult> Get([FromServices] IEventService EventServices)
        //{
        //    EventObject eventfull = await EventServices.GetEvent();
        //    UserEventDetails ud = new UserEventDetails();
        //    foreach(Event e in )
        //    return View(eventfull.events.eventArray);
        //}

        // GET: UserEventDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEventDetails = await _context.UserEventDetails
                .FirstOrDefaultAsync(m => m.IEventId == id);
            if (userEventDetails == null)
            {
                return NotFound();
            }

            return View(userEventDetails);
        }

        // GET: UserEventDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserEventDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IEventId,city_name,description,start_time,stop_time,title,venue_name,venue_address,UserId,Username")] UserEventDetails userEventDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userEventDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userEventDetails);
        }

        // GET: UserEventDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEventDetails = await _context.UserEventDetails.FindAsync(id);
            if (userEventDetails == null)
            {
                return NotFound();
            }
            return View(userEventDetails);
        }

        // POST: UserEventDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IEventId,city_name,description,start_time,stop_time,title,venue_name,venue_address,UserId,Username")] UserEventDetails userEventDetails)
        {
            if (id != userEventDetails.IEventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userEventDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserEventDetailsExists(userEventDetails.IEventId))
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
            return View(userEventDetails);
        }

        // GET: UserEventDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEventDetails = await _context.UserEventDetails
                .FirstOrDefaultAsync(m => m.IEventId == id);
            if (userEventDetails == null)
            {
                return NotFound();
            }

            return View(userEventDetails);
        }

        // POST: UserEventDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userEventDetails = await _context.UserEventDetails.FindAsync(id);
            _context.UserEventDetails.Remove(userEventDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserEventDetailsExists(int id)
        {
            return _context.UserEventDetails.Any(e => e.IEventId == id);
        }
    }
}

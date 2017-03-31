using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZenithSociety.Data;
using ZenithSociety.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace ZenithSociety.Controllers
{
    [Produces("application/json")]
    [Route("api/Events")]
    [EnableCors("AllowAllOrigins")]
    public class EventsRestfulController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsRestfulController(ApplicationDbContext context)
        {
            _context = context;
        }

        private IEnumerable<Event> getActivities(List<Event> list) {
            foreach (var e in list) {
                e.Activity = _context.Activities.FirstOrDefault(a => a.ActivityId == e.ActivityId);
            }
            return list;
        }

        [HttpGet("{anon}")]
        public IEnumerable<Event> GetAnonEvents() {
            DateTime date = DateTime.Today;
            DateTime start = date.Date.AddDays(-(int)date.DayOfWeek + 1);
            DateTime end = start.AddDays(7);
            var events = _context.Events.Where(e => e.EventFromDate >= start
            & e.EventFromDate < end
            & e.IsActive == true).ToList();
            return getActivities(events).OrderBy(e => e.EventFromDate);
        }

        // GET: api/Events
        [HttpGet]
        [Authorize(Roles = "Member")]
        public IEnumerable<Event> GetEvents()
        {
            return getActivities(_context.Events.ToList()).OrderBy(e => e.EventFromDate);
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> GetEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Event @event = await _context.Events.SingleOrDefaultAsync(m => m.EventId == id);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> PutEvent([FromRoute] int id, [FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @event.EventId)
            {
                return BadRequest();
            }

            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Events
        [HttpPost]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> PostEvent([FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Events.Add(@event);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventExists(@event.EventId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEvent", new { id = @event.EventId }, @event);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Event @event = await _context.Events.SingleOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return Ok(@event);
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}
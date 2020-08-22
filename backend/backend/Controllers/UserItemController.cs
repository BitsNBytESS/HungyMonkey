using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserItemController : Controller
    {
        private readonly backendContext _context;

        public UserItemController(backendContext context)
        {
            _context = context;
        }

        // GET: UserItem
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserItem.ToListAsync());
        }

        // GET: UserItem/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userItem = await _context.UserItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userItem == null)
            {
                return NotFound();
            }

            return View(userItem);
        }

        // GET: UserItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] UserItem userItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userItem);
        }

        // GET: UserItem/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userItem = await _context.UserItem.FindAsync(id);
            if (userItem == null)
            {
                return NotFound();
            }
            return View(userItem);
        }

        // POST: UserItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] UserItem userItem)
        {
            if (id != userItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserItemExists(userItem.Id))
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
            return View(userItem);
        }

        // GET: UserItem/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userItem = await _context.UserItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userItem == null)
            {
                return NotFound();
            }

            return View(userItem);
        }

        // POST: UserItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var userItem = await _context.UserItem.FindAsync(id);
            _context.UserItem.Remove(userItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool UserItemExists(long id)
        {
            return _context.UserItem.Any(e => e.Id == id);
        }
    }
}

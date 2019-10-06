using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PQRSenvio.Web.Data;
using PQRSenvio.Web.Data.Entities;

namespace PQRSenvio.Web.Controllers
{
    public class DetailsController : Controller
    {
        private readonly DataContext _context;

        public DetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: Details
        public async Task<IActionResult> Index()
        {
            return View(await _context.Details.ToListAsync());
        }

        // GET: Details/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detail = await _context.Details
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detail == null)
            {
                return NotFound();
            }

            return View(detail);
        }

        // GET: Details/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,is_active,Desription,created_at,created_by_id,modified_at,modified_by_id,deleted")] Detail detail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detail);
        }

        // GET: Details/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detail = await _context.Details.FindAsync(id);
            if (detail == null)
            {
                return NotFound();
            }
            return View(detail);
        }

        // POST: Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,is_active,Desription,created_at,created_by_id,modified_at,modified_by_id,deleted")] Detail detail)
        {
            if (id != detail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetailExists(detail.Id))
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
            return View(detail);
        }

        // GET: Details/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detail = await _context.Details
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detail == null)
            {
                return NotFound();
            }

            return View(detail);
        }

        // POST: Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detail = await _context.Details.FindAsync(id);
            _context.Details.Remove(detail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetailExists(int id)
        {
            return _context.Details.Any(e => e.Id == id);
        }
    }
}

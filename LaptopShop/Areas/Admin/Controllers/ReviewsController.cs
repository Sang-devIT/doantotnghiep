using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaptopShop.Areas.Admin.Data;
using LaptopShop.Areas.Admin.Models;

namespace LaptopShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReviewsController : Controller
    {
        private readonly LaptopshopContext _context;

        public ReviewsController(LaptopshopContext context)
        {
            _context = context;
        }

        // GET: Admin/Reviews
        public async Task<IActionResult> Index()
        {
            var laptopshopContext = _context.Reviews.Include(r => r.Product).Include(r => r.User);
            return View(await laptopshopContext.ToListAsync());
        }

        // GET: Admin/Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Product)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Admin/Reviews/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Admin/Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,UserId,Rating,Content,PublishDate")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", review.ProductId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", review.UserId);
            return View(review);
        }

        // GET: Admin/Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", review.ProductId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", review.UserId);
            return View(review);
        }

        // POST: Admin/Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,UserId,Rating,Content,PublishDate")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", review.ProductId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", review.UserId);
            return View(review);
        }

        // GET: Admin/Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Product)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Admin/Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }
    }
}

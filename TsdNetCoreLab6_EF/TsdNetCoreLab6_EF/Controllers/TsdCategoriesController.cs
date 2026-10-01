using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TsdNetCoreLab6_EF.Models;
using TsdNetCoreLab_EF.Entities;

public class TsdCategoriesController : Controller
{
    private readonly TsdAppDbContext _context;

    public TsdCategoriesController(TsdAppDbContext context)
    {
        _context = context;
    }


    // GET: TsdCategories
    public async Task<IActionResult> Index()
    {
        return View(
            await _context.TsdCategories
                .ToListAsync()
        );
    }



    // GET: TsdCategories/TsdCreate
    public IActionResult TsdCreate()
    {
        return View(
            "~/Views/TsdCategories/TsdCreate.cshtml"
        );
    }

    // POST: TsdCategories/TsdCreate
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> TsdCreate(
        [Bind("Id,Name,Status")] TsdCategory tsdCategory)
    {
        if (ModelState.IsValid)
        {
            tsdCategory.CreatedDate = DateTime.Now;

            _context.TsdCategories.Add(tsdCategory);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(
            "~/Views/TsdCategories/TsdCreate.cshtml",
            tsdCategory
        );
    }



    // GET: TsdCategories/TsdDetails/5
    public async Task<IActionResult> TsdDetails(int? tsdId)
    {
        if (tsdId == null)
        {
            return NotFound();
        }

        var tsdCategory = await _context.TsdCategories
            .FirstOrDefaultAsync(x => x.Id == tsdId);

        if (tsdCategory == null)
        {
            return NotFound();
        }

        return View(
            "~/Views/TsdCategories/TsdDetails.cshtml",
            tsdCategory
        );
    }



    // GET: TsdCategories/TsdEdit/5
    public async Task<IActionResult> TsdEdit(int? tsdId)
    {
        if (tsdId == null)
        {
            return NotFound();
        }

        var tsdCategory = await _context.TsdCategories
            .FindAsync(tsdId);

        if (tsdCategory == null)
        {
            return NotFound();
        }

        return View(
            "~/Views/TsdCategories/TsdEdit.cshtml",
            tsdCategory
        );
    }

    // POST: TsdCategories/TsdEdit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> TsdEdit(
        [Bind("Id,Name,Status")] TsdCategory tsdCategory)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var oldCategory = await _context.TsdCategories
                    .FindAsync(tsdCategory.Id);

                if (oldCategory == null)
                {
                    return NotFound();
                }

                oldCategory.Name = tsdCategory.Name;
                oldCategory.Status = tsdCategory.Status;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsdCategoryExists(tsdCategory.Id))
                {
                    return NotFound();
                }

                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        return View(
            "~/Views/TsdCategories/TsdEdit.cshtml",
            tsdCategory
        );
    }



    // GET: TsdCategories/TsdDelete/5
    public async Task<IActionResult> TsdDelete(int? tsdId)
    {
        if (tsdId == null)
        {
            return NotFound();
        }

        var tsdCategory = await _context.TsdCategories
            .FirstOrDefaultAsync(x => x.Id == tsdId);

        if (tsdCategory == null)
        {
            return NotFound();
        }

        return View(
            "~/Views/TsdCategories/TsdDelete.cshtml",
            tsdCategory
        );
    }

    // POST: TsdCategories/TsdDelete
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> TsdDeleteConfirmed(int tsdId)
    {
        var tsdCategory = await _context.TsdCategories
            .FindAsync(tsdId);

        if (tsdCategory != null)
        {
            _context.TsdCategories.Remove(tsdCategory);

            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }



    private bool TsdCategoryExists(int id)
    {
        return _context.TsdCategories
            .Any(x => x.Id == id);
    }
}
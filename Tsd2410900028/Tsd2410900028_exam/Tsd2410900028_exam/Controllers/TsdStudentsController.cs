
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tsd2410900028_exam.Models;

public class TsdStudentsController : Controller
{
    private readonly TsdStudent2410900028DbContext _context;

    public TsdStudentsController(TsdStudent2410900028DbContext context)
    {
        _context = context;
    }

    // GET: TSDSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.TsdStudents.ToListAsync());
    }

    // GET: TSDSTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tsdstudent = await _context.TsdStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tsdstudent == null)
        {
            return NotFound();
        }

        return View(tsdstudent);
    }

    // GET: TSDSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TSDSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,TsdName,TsdGender,TsdBirthDay,TsdEmail,TsdPhone,TsdActive")] TsdStudent tsdstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(tsdstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(tsdstudent);
    }

    // GET: TSDSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tsdstudent = await _context.TsdStudents.FindAsync(id);
        if (tsdstudent == null)
        {
            return NotFound();
        }
        return View(tsdstudent);
    }

    // POST: TSDSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,TsdName,TsdGender,TsdBirthDay,TsdEmail,TsdPhone,TsdActive")] TsdStudent tsdstudent)
    {
        if (id != tsdstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(tsdstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsdStudentExists(tsdstudent.Id))
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
        return View(tsdstudent);
    }

    // GET: TSDSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tsdstudent = await _context.TsdStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tsdstudent == null)
        {
            return NotFound();
        }

        return View(tsdstudent);
    }

    // POST: TSDSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var tsdstudent = await _context.TsdStudents.FindAsync(id);
        if (tsdstudent != null)
        {
            _context.TsdStudents.Remove(tsdstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TsdStudentExists(int? id)
    {
        return _context.TsdStudents.Any(e => e.Id == id);
    }
}

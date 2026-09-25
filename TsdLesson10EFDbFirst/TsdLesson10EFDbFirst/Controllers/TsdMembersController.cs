
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TsdLesson10EFDbFirst.Models;

public class TsdMembersController : Controller
{
    private readonly TsdK24cnt1lesson10EfdbContext _context;

    public TsdMembersController(TsdK24cnt1lesson10EfdbContext context)
    {
        _context = context;
    }

    // GET: TSDMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.TsdMembers.ToListAsync());
    }

    // GET: TSDMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tsdmember = await _context.TsdMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tsdmember == null)
        {
            return NotFound();
        }

        return View(tsdmember);
    }

    // GET: TSDMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TSDMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,TsdUserName,TsdPassword,TsdFullName,TsdEmail,TsdPhone,TsdStatus")] TsdMember tsdmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(tsdmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(tsdmember);
    }

    // GET: TSDMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tsdmember = await _context.TsdMembers.FindAsync(id);
        if (tsdmember == null)
        {
            return NotFound();
        }
        return View(tsdmember);
    }

    // POST: TSDMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,TsdUserName,TsdPassword,TsdFullName,TsdEmail,TsdPhone,TsdStatus")] TsdMember tsdmember)
    {
        if (id != tsdmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(tsdmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsdMemberExists(tsdmember.Id))
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
        return View(tsdmember);
    }

    // GET: TSDMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tsdmember = await _context.TsdMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tsdmember == null)
        {
            return NotFound();
        }

        return View(tsdmember);
    }

    // POST: TSDMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var tsdmember = await _context.TsdMembers.FindAsync(id);
        if (tsdmember != null)
        {
            _context.TsdMembers.Remove(tsdmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TsdMemberExists(long? id)
    {
        return _context.TsdMembers.Any(e => e.Id == id);
    }
}

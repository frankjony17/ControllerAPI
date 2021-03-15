
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControllerAPI.Entities;
using ControllerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Swashbuckle.AspNetCore.Annotations;

namespace ControllerAPI.Controllers
{

    [Route("api/system-clients/")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [SwaggerTag("Requests about values")]
    [ApiController]
    public class SystemClientsController : ControllerBase
    {
        private readonly IEFCoreRepository _repository;

        public SystemClientsController(IEFCoreRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("get-all")]
        [SwaggerOperation(Summary="Gets two values", Description="Gets two hardcoded values")]
        [SwaggerResponse(200, "I guess everything worked")]
        [SwaggerResponse(417, "SQL EXCEPTION")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok(new { in_progress = "TODO" });
        }

        //// GET: SystemClients/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var systemClient = await _context.SystemClients.FirstOrDefaultAsync(m => m.Id == id);

        //    if (systemClient == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(systemClient);
        //}


        //// POST: SystemClients/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,ClientName,Description")] SystemClient systemClient)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(systemClient);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(systemClient);
        //}

        //// GET: SystemClients/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var systemClient = await _context.SystemClients.FindAsync(id);
        //    if (systemClient == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(systemClient);
        //}

        //// POST: SystemClients/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,ClientName,Description")] SystemClient systemClient)
        //{
        //    if (id != systemClient.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(systemClient);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SystemClientExists(systemClient.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(systemClient);
        //}

        //// GET: SystemClients/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var systemClient = await _context.SystemClients
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (systemClient == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(systemClient);
        //}

        //// POST: SystemClients/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var systemClient = await _context.SystemClients.FindAsync(id);
        //    _context.SystemClients.Remove(systemClient);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SystemClientExists(int id)
        //{
        //    return _context.SystemClients.Any(e => e.Id == id);
        //}

        //[HttpPost("base64")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public IActionResult GetTest([FromBody] SystemClient systemClient)
        //{
        //    try
        //    {
        //        return Ok(new { payload = systemClient });
        //    }
        //    catch (System.FormatException e)
        //    {
        //        return BadRequest(new { detail = "Bad base64 string", message = e.Message });
        //    }
        //}
    }
}

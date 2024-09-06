using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthAPI;
using AuthAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace VisaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisaRequestStatusController : ControllerBase
    {
        private readonly AuthAPIContext _context;

        public VisaRequestStatusController(AuthAPIContext context)
        {
            _context = context;
        }



        // PUT: api/VisaRequestStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisaRequestStatus(int id, VisaRequestStatus visaRequestStatus)
        {
            if (id != visaRequestStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(visaRequestStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisaRequestStatusExists(id))
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

       

        // DELETE: api/VisaRequestStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisaRequestStatus(int id)
        {
            var visaRequestStatus = await _context.Statuses.FindAsync(id);
            if (visaRequestStatus == null)
            {
                return NotFound();
            }

            _context.Statuses.Remove(visaRequestStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VisaRequestStatusExists(int id)
        {
            return _context.Statuses.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthAPI;
using AuthAPI.Models;
using VisaAPI.DTO;
using Microsoft.AspNetCore.Authorization;

namespace VisaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly AuthAPIContext _context;

        public UserInfoController(AuthAPIContext context)
        {
            _context = context;
        }

        // GET: api/UserInfo
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInfoDTO>>> GetUserInfos()
        {
            // Load related data using Include and ThenInclude for nested properties
            var userInfos = await _context.UserInfos
                .Include(u => u.EmergencyContacts) // Include EmergencyContacts
                .Include(u => u.NaturalizationInfo) // Include NaturalizationInfo
                .Include(u => u.Spouse) // Include Spouse
                .Include(u => u.Passport) // Include Passport
                .Include(u => u.EntryVisas) // Include EntryVisas
                    .ThenInclude(e => e.EntryVisaApprovals) // Load nested data in EntryVisas
                .Include(u => u.Profession) // Include Profession
                .Include(u => u.ResidenceVisaInfo) // Include ResidenceVisaInfo
                    .ThenInclude(r => r.ResidenceVisaApprovals)
                .Include(u=>u.ResidenceVisaInfo)
                    .ThenInclude(r=>r.Business)
                .Include(u=>u.Status)
                    // Load nested data in ResidenceVisaInfo
                .ToListAsync();

            // Convert the list of UserInfo to UserInfoDTO using ToDTO method
            var userInfoDTOs = userInfos.Select(u => UserInfoDTO.ToDTO(u)).ToList();

            // Return the list of UserInfoDTO objects
            return Ok(userInfoDTOs);
        }

        // GET: api/UserInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserInfo>> GetUserInfo(int id)
        {
            var userInfo = await _context.UserInfos.FindAsync(id);

            if (userInfo == null)
            {
                return NotFound();
            }

            return userInfo;
        }

        // PUT: api/UserInfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserInfo(int id, UserInfo userInfo)
        {
            if (id != userInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(userInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserInfoExists(id))
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

        // POST: api/UserInfo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserInfoDTO>> PostUserInfo(UserInfoDTO userInfoDTO)
        {
            // Convert the DTO to the UserInfo entity
            UserInfo userInfo = UserInfoDTO.FromDTO(userInfoDTO);
            userInfo.CreatedAt = DateTime.UtcNow;
            if (userInfo.EmergencyContacts != null)
            {
                foreach (var contact in userInfo.EmergencyContacts)
                {
                    contact.Id = 0; // Ensure that Id is not set to avoid PK conflict
                }
            }

            // Add the new userInfo object to the database
            _context.UserInfos.Add(userInfo);
            await _context.SaveChangesAsync();

            // Map the saved userInfo back to DTO to include generated ID (if necessary)
            UserInfoDTO createdUserInfoDTO = UserInfoDTO.ToDTO(userInfo);

            // Return the created UserInfoDTO object with 201 status
            return CreatedAtAction(nameof(GetUserInfo), new { id = createdUserInfoDTO.Id }, createdUserInfoDTO);
        }

        // DELETE: api/UserInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserInfo(int id)
        {
            var userInfo = await _context.UserInfos.FindAsync(id);
            if (userInfo == null)
            {
                return NotFound();
            }

            _context.UserInfos.Remove(userInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserInfoExists(int id)
        {
            return _context.UserInfos.Any(e => e.Id == id);
        }
    }
}

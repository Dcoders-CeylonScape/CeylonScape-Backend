using AuthAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly AuthAPIContext _context;

    public UserController(AuthAPIContext context)
    {
        _context = context;
    }

    // GET: User
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
    {
        var users = await _context.User
            .Select(u => UserDTO.FromUser(u))
            .ToListAsync();
        return users;
    }

    // GET: User/5
    [HttpGet("{id}")]
    [Authorize]
    public async Task<ActionResult<UserDTO>> GetUser(long id)
    {
        var user = await _context.User.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return UserDTO.FromUser(user);
    }

    // POST: User
    [HttpPost]
    public async Task<ActionResult<UserDTO>> CreateUser(UserDTO userDto)
    {
        userDto.Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
        var user = userDto.ToUser();

        _context.User.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetUser), new { id = user.UserID }, UserDTO.FromUser(user));
    }

    // PUT: User/5
    [HttpPut("{id}")]
    [Authorize]
    public async Task<ActionResult<UserDTO>> UpdateUser(long id, UserDTO userDto)
    {
        if (id != userDto.UserID)
        {
            return BadRequest();
        }

        var user = await _context.User.FindAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        if(userDto.FirstName != string.Empty) user.FirstName = userDto.FirstName;
        if(userDto.LastName != string.Empty) user.LastName = userDto.LastName;
        if(userDto.MobileNumber != string.Empty) user.MobileNumber = userDto.MobileNumber;
        if(userDto.Email != string.Empty) user.Email = userDto.Email;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!UserExists(id))
        {
            return NotFound();
        }

        return UserDTO.FromUser(user);
    }

    // DELETE: User/5
    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteUser(long id)
    {
        var user = await _context.User.FindAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        _context.User.Remove(user);
        await _context.SaveChangesAsync();

        return Ok(new { Status = "Success" });
    }

    private bool UserExists(long id)
    {
        return _context.User.Any(e => e.UserID == id);
    }
}
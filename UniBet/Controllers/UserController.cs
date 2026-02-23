using Microsoft.AspNetCore.Mvc;
using UniBet.Entities;
using UniBet.DTOs;
using UniBet.Interfaces.IServices;

namespace UniBet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Get")]
        public IActionResult GetUser([FromQuery] int id)
        {
            var user = _userService.GetUserData(id);
            return Ok(user);
        }

        [HttpPost("AddDeposit")]
        public IActionResult AddDeposit([FromBody] DepositDTO depositDto)
        {
            try
            {
                _userService.Deposit(depositDto);
                return Ok("Deposit completed successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
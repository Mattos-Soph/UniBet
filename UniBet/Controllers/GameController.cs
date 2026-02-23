using Microsoft.AspNetCore.Mvc;
using UniBet.DTOs;
using UniBet.Interfaces.IServices;

namespace UniBet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost("Add")]
        public IActionResult AddGame([FromBody] GameDTO newGame)
        {
            _gameService.CreateGame(newGame);
            return Ok("Game successfully added.");
        }

        [HttpGet("GetById")]
        public IActionResult GetGameById([FromQuery] Guid id)
        {
            var result = _gameService.GetGameData(id);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllGames()
        {
            return Ok("Controller working");
        }

        [HttpPut("Update")]
        public IActionResult UpdateGame([FromQuery] Guid id, [FromBody] GameDTO updatedGame)
        {
            try
            {
                _gameService.EditGame(id, updatedGame);
                return Ok("Game successfully updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Remove")]
        public IActionResult RemoveGame([FromQuery] Guid id)
        {
            try
            {
                _gameService.DeleteGame(id);
                return Ok("Game successfully removed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
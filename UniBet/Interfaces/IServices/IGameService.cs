using UniBet.DTOs;
using UniBet.Entities;

public interface IGameService
{
    void CreateGame(GameDTO createGame);
    Game GetGameData(Guid id);
    List<Game> GetAllGames();
    void EditGame(Guid id, GameDTO editGame);
    void DeleteGame(Guid id);
}
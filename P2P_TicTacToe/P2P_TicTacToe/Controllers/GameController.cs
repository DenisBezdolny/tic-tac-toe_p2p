using Microsoft.AspNetCore.Mvc;

[Route("api/game")]
[ApiController]
public class GameController : ControllerBase
{
    private static string[,] _board = new string[3, 3];
    private static string _currentPlayer = "X";

    [HttpPost("move")]
    public IActionResult MakeMove([FromBody] MoveRequest move)
    {
        if (_board[move.X, move.Y] == null && move.Player == _currentPlayer)
        {
            _board[move.X, move.Y] = move.Player;
            _currentPlayer = move.Player == "X" ? "O" : "X";

            var winner = CheckWinner();
            return Ok(new { success = true, board = _board, winner });
        }
        return BadRequest("Invalid move");
    }

    private string CheckWinner()
    {
        string[] players = { "X", "O" };
        foreach (var player in players)
        {
            if ((_board[0, 0] == player && _board[0, 1] == player && _board[0, 2] == player) ||
                (_board[1, 0] == player && _board[1, 1] == player && _board[1, 2] == player) ||
                (_board[2, 0] == player && _board[2, 1] == player && _board[2, 2] == player) ||
                (_board[0, 0] == player && _board[1, 0] == player && _board[2, 0] == player) ||
                (_board[0, 1] == player && _board[1, 1] == player && _board[2, 1] == player) ||
                (_board[0, 2] == player && _board[1, 2] == player && _board[2, 2] == player) ||
                (_board[0, 0] == player && _board[1, 1] == player && _board[2, 2] == player) ||
                (_board[0, 2] == player && _board[1, 1] == player && _board[2, 0] == player))
            {
                return player;
            }
        }
        return null;
    }
}

public class MoveRequest
{
    public string Player { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
}

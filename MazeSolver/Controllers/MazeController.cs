using MazeSolver.Models;
using Microsoft.AspNetCore.Mvc;

namespace MazeSolver.Controllers
{
    [Produces("application/json")]
    [Route("api/Maze")]
    public class MazeController : Controller
    {
        [HttpPost]
        public string Solver([FromBody]MazeInput input)
        {
            return MazeSolver(input.Input);
        }

        private string MazeSolver(string input)
        {
            ////List<string> mapLines = input.Split(' ').ToList();
            ////List<Cell> cells = new List<Cell>();
            ////int x = 0;
            ////int y = 0;
            ////foreach(var line in mapLines)
            ////{
            ////    foreach (char c in line.ToCharArray())
            ////    {
            ////        var cell = new Cell
            ////        {
            ////            Top = x == 0 ? null : Getpoint

            ////        };
            ////        cells.Add(cell);
            ////        y++;
            ////    }
            ////    x++;
            ////}

            return input + " - Maze is solved";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeSolver.Models
{
    public class Cell
    {
        public Point? Top { get; set; }

        public Point? Bottom { get; set; }

        public Point? Left { get; set; }

        public Point? Right { get; set; }

        public Point? Current { get; set; }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }
    }
}

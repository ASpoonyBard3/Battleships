using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class FiringBoard : GameBoard
    {
        public List<Coordinates> GetOpenRandomPanels() { }

        public List<Coordinates> GetHitNeighbours() { }

        public List<Panel> GetNeighbours(Coordinates coordinates) { }
    }
}

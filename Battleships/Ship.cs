using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set;  }
        public OccupationType occupationType { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Width;
            }
        }
    }
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Width = 2;
            occupationType = OccupationType.Destroyer;
        }
    }

    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Width = 3;
            occupationType = OccupationType.Submarine;
        }
    }

    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Width = 3;
            occupationType = OccupationType.Cruiser;
        }
    }

    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Width = 4;
            occupationType = OccupationType.Battleship;
        }
    }

    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Aircraft Carrier";
            Width = 5;
            occupationType = OccupationType.Carrier;
        }
    }
}

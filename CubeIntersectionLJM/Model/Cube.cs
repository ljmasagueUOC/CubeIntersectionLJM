using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubeIntersectionLJM.Model
{
    public class Cube
    {
        private Dictionary<string, int> coords = new Dictionary<string, int>();
        public int Size;

        public Cube()
        {

        }

        public void AddCoordinates(int x, int y, int z)
        {
            if (coords.ContainsKey("X") || coords.ContainsKey("Y") || coords.ContainsKey("Z"))
            {
                coords = new Dictionary<string, int>();
            }

            coords.Add("X", x);
            coords.Add("Y", y);
            coords.Add("Z", z);
        }

        public bool AddSize(int size)
        {
            if (size <= 0)
                return false;
            this.Size = size;
            return true;
        }
        public int GetLowerLimit(string key)
        {
            return coords[key] - (Size / 2);
        }

        public int GetUpperLimit(string key)
        {
            return coords[key] + (Size / 2);
        }

        public IEnumerable<string> GetCoordinates()
        {
            return coords.Keys.ToList();
        }

        public int GetCoordinates(string coordinate)
        {
            return coords[coordinate];
        }
    }
}

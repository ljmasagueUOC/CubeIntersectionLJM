using System;
using System.Collections.Generic;
using System.Text;
using CubeIntersectionLJM.Interfaces;
using CubeIntersectionLJM.Model;

namespace CubeIntersectionLJM.Business
{
    public class ColitionTwoCube : IColition
    {
        private Cube cube1;
        private Cube cube2;

        public ColitionTwoCube(Cube cube1, Cube cube2)
        {
            this.cube1 = cube1;
            this.cube2 = cube2;
        }

        #region public methods
        public bool HasColision()
        {
            
            foreach (string coordinate in cube1.GetCoordinates())
            {
                if (Colision(coordinate) > 0)
                {
                    return true;
                }
            }

            return false;
        }
        public int IntersectedVolume()
        {
            return Colision("X") * Colision("Y") * Colision("Z");
        }
        #endregion
        #region private methods
        private bool Cube1InsideCube2(string coordinateName)
        {
            return cube1.GetUpperLimit(coordinateName) > cube2.GetUpperLimit(coordinateName);
        }

        private bool IntersectionOnTheRight(string coordinateName)
        {
            return cube1.GetLowerLimit(coordinateName) > cube2.GetLowerLimit(coordinateName) && cube1.GetLowerLimit(coordinateName) <= cube2.GetUpperLimit(coordinateName);
        }

        private bool Cube2InsideCube1(string coordinateName)
        {
            return cube1.GetUpperLimit(coordinateName) < cube2.GetUpperLimit(coordinateName);
        }

        private bool IntersectedOnTheLeft(string coordinateName)
        {
            return cube1.GetLowerLimit(coordinateName) <= cube2.GetLowerLimit(coordinateName) && cube1.GetUpperLimit(coordinateName) > cube2.GetLowerLimit(coordinateName);
        }

        private int Colision(string coordinateName)
        {
            if (IntersectedOnTheLeft(coordinateName))
            {
                if (Cube2InsideCube1(coordinateName))
                {
                    return cube1.GetUpperLimit(coordinateName) - cube2.GetLowerLimit(coordinateName);
                }
                else
                {
                    return cube2.Size;
                }
            }

            if (IntersectionOnTheRight(coordinateName))
            {
                if (Cube1InsideCube2(coordinateName))
                {
                    return cube2.GetUpperLimit(coordinateName) - cube1.GetLowerLimit(coordinateName);
                }
                else
                {
                    return cube1.Size;
                }
            }

            return 0;
        }
        #endregion
    }
}

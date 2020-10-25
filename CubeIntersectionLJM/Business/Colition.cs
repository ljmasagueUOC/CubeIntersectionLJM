using System;
using System.Collections.Generic;
using System.Text;
using CubeIntersectionLJM.Interfaces;

namespace CubeIntersectionLJM.Business
{
    public abstract class Colition
    {
        private readonly IColition _colisionStrategy;

        public Colition(IColition colisionStrategy)
        {
            this._colisionStrategy = colisionStrategy;
        }

        public bool HasColision()
        {
            return _colisionStrategy.HasColision();
        }

        public int IntersectedVolume()
        {
            return _colisionStrategy.IntersectedVolume();
        }
    }
}

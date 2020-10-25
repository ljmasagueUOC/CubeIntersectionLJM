using System;
using System.Collections.Generic;
using System.Text;

namespace CubeIntersectionLJM.Interfaces
{
    public interface IColition
    {
        bool HasColision();
        int IntersectedVolume();
    }
}

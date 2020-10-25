using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeIntersectionLJM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubeIntersectionLJM.Model.Tests
{
    [TestClass()]
    public class CubeTests
    {
        Cube cube = new Cube();
        [TestMethod()]
        public void AddCoordinatesTestNEW()
        {
            cube.AddCoordinates(1,1,1);
            
            Assert.IsTrue(cube.GetCoordinates("X")==1 && cube.GetCoordinates("Y") == 1 && cube.GetCoordinates("Z") == 1);
        }

        [TestMethod()]
        public void AddCoordinatesTestUsed()
        {
            
            cube.AddCoordinates(0,0,0);
            cube.AddCoordinates(1, 1, 1);

            Assert.IsTrue(cube.GetCoordinates("X") == 1 && cube.GetCoordinates("Y") == 1 && cube.GetCoordinates("Z") == 1);
        }
        [TestMethod()]
        public void AddSizeTestOk()
        {
            Assert.IsTrue(cube.AddSize(1));
        }

        public void AddSizeTestKo()
        {
            Assert.IsFalse(cube.AddSize(-1));
        }
        [TestMethod()]
        public void GetLowerLimitTest()
        {
            cube.AddCoordinates(0, 0, 0);
            cube.AddSize(2);

            Assert.AreEqual(cube.GetLowerLimit("X"), -1);
        }

        [TestMethod()]
        public void GetUpperLimitTest()
        {
            cube.AddCoordinates(0, 0, 0);
            cube.AddSize(2);

            Assert.AreEqual(cube.GetUpperLimit("X"), 1);
        }
    }
}
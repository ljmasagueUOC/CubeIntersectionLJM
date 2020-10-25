using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeIntersectionLJM.Business;
using System;
using System.Collections.Generic;
using System.Text;
using CubeIntersectionLJM.Model;

namespace CubeIntersectionLJM.Business.Tests
{
    [TestClass()]
    public class ColitionTwoCubeTests
    {
        Cube cube1 = new Cube();
        Cube cube2 = new Cube();

        [TestMethod()]
        public void HasColisionTestWithNoColition()
        {
            cube1.AddCoordinates(0,0,0);
            cube2.AddCoordinates(10,10,10);

            cube1.AddSize(3);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            bool result = colition.HasColision();

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void HasColisionTestWithColition()
        {
            cube1.AddCoordinates(0, 0, 0);
            cube2.AddCoordinates(0, 0, 0);

            cube1.AddSize(3);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            bool result = colition.HasColision();

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube2InsideCube1()
        {
            cube1.AddCoordinates(0, 0, 0);
            cube2.AddCoordinates(0, 0, 0);

            cube1.AddSize(3);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result==8);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube1InsideCube2()
        {
            cube1.AddCoordinates(0, 0, 0);
            cube2.AddCoordinates(0, 0, 0);

            cube1.AddSize(2);
            cube2.AddSize(4);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result == 8);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube2UpperRightDeeper()
        {
            cube1.AddCoordinates(0, 0, 0);
            cube2.AddCoordinates(1, 1, 1);

            cube1.AddSize(2);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube2LowerRightDeeper()
        {
            cube1.AddCoordinates(0, 1, 0);
            cube2.AddCoordinates(1, 0, 1);

            cube1.AddSize(2);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube2UpperLeftDeeper()
        {
            cube1.AddCoordinates(1, 0, 0);
            cube2.AddCoordinates(0, 1, 1);

            cube1.AddSize(2);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube2UpperRightNotDeeper()
        {
            cube1.AddCoordinates(0, 0, 1);
            cube2.AddCoordinates(1, 1, 0);

            cube1.AddSize(2);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void IntersectedVolumeTestCube2UpperLeftNotDeeper()
        {
            cube1.AddCoordinates(1, 0, 1);
            cube2.AddCoordinates(0, 1, 0);

            cube1.AddSize(2);
            cube2.AddSize(2);

            ColitionTwoCube colition = new ColitionTwoCube(cube1, cube2);
            int result = colition.IntersectedVolume();

            Assert.IsTrue(result == 1);
        }
    }
}
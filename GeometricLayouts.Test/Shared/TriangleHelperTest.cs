using System;
using System.Collections.Generic;
using GeometricLayouts.Entities;
using GeometricLayouts.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLayouts.Test.Shared
{
    [TestClass]
    public class TriangleHelperTest
    {
        [TestMethod]
        public void Check_All_Coordinates_DoesNot_Form_StraightLine()
        {
            List<Vertex> InputCoordinates = new List<Vertex>();
            InputCoordinates.Add(new Vertex(0,0));
            InputCoordinates.Add(new Vertex(0,10));
            InputCoordinates.Add(new Vertex(10,10));

            bool result = TriangleHelper.ValidateCoordinates(InputCoordinates);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_If_Coordinates_Form_StraightLine()
        {
            List<Vertex> InputCoordinates = new List<Vertex>();
            InputCoordinates.Add(new Vertex(0, 0));
            InputCoordinates.Add(new Vertex(0, 10));
            InputCoordinates.Add(new Vertex(0, 20));

            bool result = TriangleHelper.ValidateCoordinates(InputCoordinates);

            Assert.AreEqual(false, result);
        }
    }
}

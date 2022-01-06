using System;
using System.Collections.Generic;
using GeometricLayouts.Entities;
using GeometricLayouts.Interfaces;
using GeometricLayouts.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GeometricLayouts.Test.Services
{
    [TestClass]
    public class TriangleServiceTest
    {
        private IService tempTriangleService;
        [TestInitialize]
        public void Setup()
        {
            tempTriangleService = new TriangleService();
        }
        [TestMethod]
        public void Check_GetCoordinates()
        {
            string position = "C5";
            List<Vertex> expectedResult = new List<Vertex>();

            expectedResult.Add(new Vertex(20, 20));
            expectedResult.Add(new Vertex(20, 30));
            expectedResult.Add(new Vertex(30, 30));

            List<Vertex> actulaResult = tempTriangleService.GetCoordinates(position);
                       
            CollectionAssert.AreEqual(expectedResult, actulaResult);
        }

        [TestMethod]
        public void Check_GetPosition()
        {
            List<Vertex> Vertices = new List<Vertex>();
            Vertices.Add(new Vertex(20, 20));
            Vertices.Add(new Vertex(20, 30));
            Vertices.Add(new Vertex(30, 30));
            string expectedResult = "C5";

            string actulaResult = tempTriangleService.GetPosition(Vertices);

            Assert.AreEqual(expectedResult, actulaResult);
        }
    }
}

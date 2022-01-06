using GeometricLayouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometricLayouts.Entities
{
    public class Triangle : IShape
    {
        public Triangle()
        {

        }
        public Triangle(Vertex v1, Vertex v2, Vertex v3)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
        }

        public Vertex V1 { get; set; }
        public Vertex V2 { get; set; }
        public Vertex V3 { get; set; }

        public bool AreEqual(Triangle triangle2)
        {
            return (V1.Equals(triangle2.V1) && V2.Equals(triangle2.V2) && V3.Equals(triangle2.V3));
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Triangle T = (Triangle)obj;
                return (V1.Equals(T.V1) && V2.Equals(T.V2) && V3.Equals(T.V3));
            }
        }

        public List<Vertex> GetVertices()
        {
            return new List<Vertex> { V1, V2, V3 };
        }
    }
}
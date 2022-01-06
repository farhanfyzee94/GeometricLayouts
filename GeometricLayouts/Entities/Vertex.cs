using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometricLayouts.Entities
{
    public class Vertex
    {    
        public int X { get; set; }
        public int Y { get; set; }    

        public Vertex()
        {
        }

        public Vertex(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Vertex V = (Vertex)obj;
                return (X == V.X) && (Y == V.Y);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeometricLayouts.Entities;

namespace GeometricLayouts.Shared
{
    public class TriangleHelper : Helper
    {
        public static bool ValidateCoordinates(List<Vertex> vertices)
        {
            bool isStraightLine = true;

            try
            {
                //Currently I am only verifying that the three coordinates should not fall in a single line
                isStraightLine = ((vertices[0].X == vertices[1].X) && (vertices[1].X == vertices[2].X)) ||
                    ((vertices[0].Y == vertices[1].Y) && (vertices[1].Y == vertices[2].Y));
            }
            catch
            {
                //Do nothing. Returns false.
            }
            
            return !isStraightLine;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
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

                TriangleHelper.AreCoordinatesAMultipleOfLengthAndBreadth(vertices);
            }
            catch
            {
                //Do nothing. Returns false.
            }
            
            return !isStraightLine && TriangleHelper.AreCoordinatesAMultipleOfLengthAndBreadth(vertices); ;
        }

        //Not properly tested.
        public static bool AreCoordinatesAMultipleOfLengthAndBreadth(List<Vertex> vertices)
        {
            bool isValid = false;
            int triangleLength, triangleBreadth;
            triangleLength = Convert.ToInt32(ConfigurationManager.AppSettings["TRIANGLE_LENGTH"]);
            triangleBreadth = Convert.ToInt32(ConfigurationManager.AppSettings["TRIANGLE_BREADTH"]);

            foreach (Vertex v in vertices)
            {
                if ((v.X >= 0 &&  v.X % triangleBreadth != 0) || (v.Y >= 0 && v.Y % triangleLength != 0))
                    return isValid;
            }

            isValid = true;
            return isValid;
        }
    }
}
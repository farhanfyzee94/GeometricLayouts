using System;
using System.Collections.Generic;
using System.Configuration;
using GeometricLayouts.Entities;
using GeometricLayouts.Interfaces;
using GeometricLayouts.Shared;

namespace GeometricLayouts.Services
{
    public class TriangleService : IService
    {
        private int TriangleLength;
        private int TriangleBreadth;
        public TriangleService()
        {
            TriangleLength = Convert.ToInt32(ConfigurationManager.AppSettings["TRIANGLE_LENGTH"]);
            TriangleBreadth = Convert.ToInt32(ConfigurationManager.AppSettings["TRIANGLE_BREADTH"]);
        }

        public List<Vertex> GetCoordinates(string position)
        {
            int iRow, iColumn;
            bool bColumnIsOdd;
            Triangle ResultTriangle;

            try
            {
                string[] rowAndColumn = Helper.SplitRowAndColumn(position);
                iRow = Helper.ConvertRowAlphabetToNumber(rowAndColumn[0]);
                iColumn = Convert.ToInt32(rowAndColumn[1]) - 1;
                bColumnIsOdd = ((iColumn + 1) % 2 == 1);

                ResultTriangle = GenerateTriangle(iRow, iColumn, bColumnIsOdd);
            }
            catch(Exception ex)
            {
                return null;
            }

            return ResultTriangle.GetVertices();
        }

        public string GetPosition(List<Vertex> vertices)
        {
            string position;
            int rowSum = 0, colSum = 0;
            int row, column;

            try
            {
                foreach (Vertex v in vertices)
                {
                    colSum += v.X;
                    rowSum += v.Y;
                }

                //The general idea here is, row and column can be figured out using average value of x & y coordinates
                row = (rowSum / 3) / TriangleBreadth;
                column = (colSum * 2 / 3) / TriangleBreadth;

                position = String.Format("{0}{1}", Helper.ConvertRowNumberToAlphabet(row), Convert.ToString(column + 1));
            }
            catch(Exception ex)
            {
                return null;
            }

            return position;
        }

        public Triangle GenerateTriangle(int row, int column, bool isColumnOdd)
        {
            Vertex V1 = new Vertex();
            Vertex V2 = new Vertex();
            Vertex V3 = new Vertex();

            try
            {
                V1.X = (column / 2) * TriangleBreadth;
                V3.X = ((column / 2) + 1) * TriangleBreadth;
                V2.X = isColumnOdd ? V1.X : V3.X;

                V1.Y = row * TriangleLength;
                V3.Y = (row + 1) * TriangleLength;
                V2.Y = !isColumnOdd ? V1.Y : V3.Y;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return new Triangle(V1, V2, V3);
        }
    }
}
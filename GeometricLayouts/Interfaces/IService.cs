using GeometricLayouts.Entities;
using System.Collections.Generic;


namespace GeometricLayouts.Interfaces
{
    public interface IService
    {
        List<Vertex> GetCoordinates(string position);
        string GetPosition(List<Vertex> vertices);
    }
}

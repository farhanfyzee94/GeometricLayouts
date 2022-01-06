using GeometricLayouts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLayouts.Interfaces
{
    public interface IShape
    {
        List<Vertex> GetVertices();
    }
}

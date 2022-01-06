using System;
using System.Web.Http;
using Newtonsoft.Json;
using GeometricLayouts.Shared;
using GeometricLayouts.Entities;
using GeometricLayouts.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace GeometricLayouts.Controllers
{
    public class TriangleController : ApiController
    {
        private IService TriangleService;
        public TriangleController(IService triangleService)
        {
            this.TriangleService = triangleService;
        }

        [HttpGet]
        [Route("api/triangle/TriangleCoordinates/{position}")]
        public string TriangleCoordinates(string position)
        {
            List<Vertex> Coordinates = new List<Vertex>();

            if (TriangleHelper.ValidateRowAndColumn(position))
            {
                Coordinates = TriangleService.GetCoordinates(position);
            }

            if (Coordinates.Count == 0)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(String.Format("Not able to get coordinates for triangle at {0}",position)),
                    ReasonPhrase = "Invalid triangle position."
                };
                throw new HttpResponseException(resp);
            }

            return JsonConvert.SerializeObject(Coordinates);
        }

        [HttpGet]
        [Route("api/triangle/TrianglePosition")]
        public string TrianglePosition([FromUri]string coordinates)
        {
            string position = String.Empty;

            List<Vertex> InputCoordinates = new List<Vertex>();
            InputCoordinates = JsonConvert.DeserializeObject<List<Vertex>>(coordinates);

            if (TriangleHelper.ValidateCoordinates(InputCoordinates))
            {
                position = TriangleService.GetPosition(InputCoordinates);
            }

            if (position == null || position == String.Empty)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("No triangle is found with the given coordinates"),
                    ReasonPhrase = "Triangle not found."
                };
                throw new HttpResponseException(resp);
            }

            return position;
        }
    }
}

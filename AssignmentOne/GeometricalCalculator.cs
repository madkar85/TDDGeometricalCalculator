using AssignmentOne.GeoShapes;
using AssignmentOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOne
{
    public class GeometricalCalculator
    {
        /*
        public float GetArea(IGeometricalThings geoThings)
        {
            return 0;
        }

        public float GetPerimeter(IGeometricalThings geoThings)
        {
            return 0;
        }
        */


        public float GetPerimeter(IGeometricalThings[] geoThings)
        {
            if(geoThings == null)
            {
                return 0;
            }
            return geoThings.Sum(p=>p.GetPerimeter());

        }
    }
}

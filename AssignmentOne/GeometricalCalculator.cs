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
        /// <summary>
        /// Räknar ut omkretsen på en array av olika objekt/former
        /// </summary>
        /// <param name="geoThings"></param>
        /// <returns></returns>
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

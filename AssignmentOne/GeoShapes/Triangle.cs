﻿using AssignmentOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne.GeoShapes
{
    public class Triangle : IGeometricalThings
    {
        public float Side { get; set; }

        public Triangle(float side)
        {
            Side = side;
        }

        public float GetArea()
        {
            if (Side <= 0)
            {
                return 0;
            }
            var halfSide = Side / 2;
            var area = Math.Sqrt(Side * Side - halfSide * halfSide);
            return (float)Math.Round(area, 2);
        }

        public float GetPerimeter()
        {
            if(Side <= 0)
            {
                return 0;
            }
            return Side + Side + Side;
        }
    }
}

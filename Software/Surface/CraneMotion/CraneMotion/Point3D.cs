﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraneMotion
{
    public class Point3D
    {
        public float X;
        public float Y;
        public float Z;

        public Point3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
    }
}

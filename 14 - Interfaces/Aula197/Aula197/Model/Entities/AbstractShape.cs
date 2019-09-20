﻿using System;
using System.Collections.Generic;
using System.Text;
using Aula197.Model.Enums;

namespace Aula197.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}

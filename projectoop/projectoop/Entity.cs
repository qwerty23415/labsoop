﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop;

public class Entity
{
    public int Speed { get; private set; }

    public double Weight { get; private set; }

    public Color BodyColor { get; private set; }

    public Color AdditionalColor { get; private set; }

    public bool Body { get; private set; }

    public bool Tent { get; private set; }

    public double Step => Speed * 100 / Weight;

    public void Init(int speed, double weight, Color bodyColor, Color additionalColor, bool body, bool tent)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodyColor;
        AdditionalColor = additionalColor;
        Body = body;
        Tent = tent;

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePC : PropertyCard
{
    public override int Effect(int dailyFocus)
    {
        dailyFocus = dailyFocus*2;
        return dailyFocus;
    }
}

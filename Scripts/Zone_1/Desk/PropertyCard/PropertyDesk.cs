using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyDesk : Desk
{
    public List<PropertyCard> propertyCards;

    public override int ApplyEffect(int dailyFocus)
    {
        foreach(PropertyCard i in propertyCards)
        {
            dailyFocus = i.Effect(dailyFocus);
        }

        return dailyFocus;
    }
}

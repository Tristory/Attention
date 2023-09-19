using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyD : Distractor
{
    //Var Level: Define how much property will give per day.
    public int level;

    //Function LvUP: Increase the level using AP.
    public void LevelUp()
    {
        level += 1;
        dA.dailyFocus *= 2;
    }
}

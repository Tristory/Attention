using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public virtual int Effect(int dailyFocus)
    {
        return dailyFocus;
    }
}

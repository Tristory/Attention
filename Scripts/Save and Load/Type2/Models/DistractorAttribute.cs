using System;
using System.Collections.Generic;

[System.Serializable]
public class DistractorAttribute
{
    public string dName;
    public int focusValue;
    public int dailyFocus;
    public int lastCollectedDay;

    public List<string> cards;
}

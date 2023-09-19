using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Save Object/World Time")]
[System.Serializable]
public class WorldTime : ScriptableObject
{
    public int minute;
    public int hour;
    public int day;

}

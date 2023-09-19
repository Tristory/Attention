using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Save Object/Zone distractors")]
[System.Serializable]
public class ZoneD : ScriptableObject
{
    public List<DistractorAttribute> distractorAts;
}

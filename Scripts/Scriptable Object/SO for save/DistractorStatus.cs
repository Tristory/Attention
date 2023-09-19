using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

[CreateAssetMenu(menuName = "Save Object/Distractor status")]
[System.Serializable]
public class DistractorStatus : ScriptableObject
{
    public string DName;
    public int focusValue;
    public Sprite sprite;
}

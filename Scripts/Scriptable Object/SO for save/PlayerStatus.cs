using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Save Object/Player status")]
[System.Serializable]
public class PlayerStatus : ScriptableObject
{
    public int attention;
}

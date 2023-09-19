using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Act : ScriptableObject
{
    public List<React> reactors = new List<React>();

    public void Raise()
    {
        for (int i = reactors.Count - 1; i >= 0; i --)
        {
            reactors[i].OnSignalRaised();
        }
    }
    public void RegisterListener(React reactor)
    {
        reactors.Add(reactor);
    }
    public void DeRegisterListener(React reactor)
    {
        reactors.Remove(reactor);
    }
}

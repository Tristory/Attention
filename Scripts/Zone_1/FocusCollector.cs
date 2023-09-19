using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCollector : MonoBehaviour
{
    public WorldTime worldTime;
    public DistractorAttribute dA;
    public PropertyDesk propertyDesk;
    public CardCollection cardCollection;

    public void StartUp()
    {
        dA = gameObject.GetComponent<Distractor>().dA;
        propertyDesk = gameObject.GetComponent<PropertyDesk>();
        cardCollection.AddCard(dA.cards, propertyDesk);

        CollectFocus();
    }

    private void CollectFocus()
    {
        int dayDif = worldTime.day - dA.lastCollectedDay;
        if( dayDif > 0)
        {
            dA.focusValue += propertyDesk.ApplyEffect(dA.dailyFocus)*dayDif;      
        }

        dA.lastCollectedDay = worldTime.day;
    }
}

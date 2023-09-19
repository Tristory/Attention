using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollection : MonoBehaviour
{
    public List<PropertyCard> propertyCards;
    /*public List<string> cards;
    public PropertyDesk desk;

    void Start()
    {
        AddCard();
    }*/

    public void AddCard(List<string> cards, PropertyDesk desk)
    {
        foreach(string i in cards)
        {
            PropertyCard temp = propertyCards.Find(x => x.name == i);
            if(temp != null)
            {
                desk.propertyCards.Add(temp);
            }
        }
    }
}

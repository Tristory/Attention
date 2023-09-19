using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Distractor : MonoBehaviour
{
    /*[Header("Attributes")]
    public string dName;
    public int focusValue;*/

    public DistractorAttribute dA;
    public ZoneD zone1;
    public int iD;
    public Sprite sprite;

    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        dA = zone1.distractorAts[iD];

        //Start up Focus Collector
        gameObject.GetComponent<FocusCollector>().StartUp();

        //dName = distractorAt.dName;
        //focusValue = distractorAt.focusValue;
        //AttributeSetting();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Player>() != null)
        {
            other.GetComponent<Player>().distractors.Add(this);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.GetComponent<Player>() != null)
        {
            other.GetComponent<Player>().distractors.Remove(this);
        }
    }

    /*void AttributeSetting()
    {
        dName = zone1.distractorAts[0].dName;
        focusValue = zone1.distractorAts[0].focusValue;
    }*/
}

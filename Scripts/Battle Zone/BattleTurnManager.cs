using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class BattleTurnManager : MonoBehaviour
{
    //public List<Monster> monsters; //= new List<Monster>();
    //public Monster[] monsters;

    public Monster enemy;
    public Monster player;

    private int currentN;

    public GameObject endResult;

    void Start()
    {
        SetUp();

        currentN = 0;

        TurnStart();
    }

    void Update()
    {
        //if(monsters.Count == 1)
        if(enemy == null || player == null)
        {
            BattleEnded();
        }
    }

    void SetUp()
    {
        enemy.gameObject.AddComponent<MAutoIntelligent>();
        //enemy.gameObject.GetComponent<MAutoIntelligent>().monster = enemy;
        player.gameObject.AddComponent<MController>();
    }

    public void TurnStart()
    {        
        if(currentN == 0)
        {
            enemy.inTurn = true;
            //enemy.gameObject.GetComponent<MAutoIntelligent>().InTurn();
        }
        else
        {
            player.inTurn = true;
        }

        //monsters[currentN].inTurn = true;
    }

    public void TurnEnd()
    {
        /*if(currentN == 0)
        {
            enemy.inTurn = false;
        }
        else
        {
            player.inTurn = false;
        }*/
        
        //monsters[currentN].inTurn = false;
        Tracker();
        TurnStart();
    }

    void Tracker()
    {
        /*if(currentN < monsters.Count - 1)
        {
            currentN += 1;
        }*/
        if(currentN == 0)
        {
            currentN = 1;
        }
        else
        {
            currentN = 0;
        }
    }

    void BattleEnded()
    {
        //Remove all null from the list
        //monsters.RemoveAll(x => !x);
        //Debug.Log(monsters.Count);
        endResult.SetActive(true);
    }
}

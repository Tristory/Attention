using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
//using System.Diagnostics;
//using System.Numerics;
using System.Reflection;
using UnityEngine;

public class MAutoIntelligent : MonoBehaviour
{
    public Monster monster;
    public Vector3 player;
    public List<Vector3> optionBlocks = new List<Vector3>();

    //[Header("For testing")]
    /*public GameObject currentSkill;
    public GameObject choosedBlock;
    public OBPlayer optionBlock;*/

    void Start()
    {
        monster = gameObject.GetComponent<Monster>();        
    }

    void Update()
    {
        //monster = gameObject.GetComponent<Monster>();

        if(monster.inTurn)
        {
            DecisionMaking();
        }
    }

    void DecisionMaking()
    {
        //Shape checker
        PositionChecker();

        //Consider about attack
        if(CollisionChecker())
        {
            //Debug.Log(optionBlocks.IndexOf(player));
            //Attack!
            int i = optionBlocks.IndexOf(player);
            UseSkill(i, "Attack");
        }
        else
        {
            //Consider about moving
            UseSkill(NearestBlockChecker(), "Movement");
            
        }    

        //monster.turnM.TurnEnd();
    }

    void PositionChecker()
    {
        optionBlocks.Clear();

        //Get player position
        player = monster.turnM.player.transform.position;

        foreach(Transform b in monster.shape.transform)
        {
            Vector3 temp = new Vector3();
            temp += transform.position;
            temp += b.position;

            optionBlocks.Add(temp);
        }
    }

    bool CollisionChecker()
    {
        if(optionBlocks.Contains(player))
        {
            Debug.Log("Attackable");
            return true;
        }
        else
        {
            Debug.Log("So far away");
            return false;
        }
    }

    int NearestBlockChecker()
    {
        //Find the block that is nearest to the player
        int nearestB = 0;
        float nearestD = 100;

        foreach(Vector3 b in optionBlocks)
        {
            float dist = Vector3.Distance(player, b);
            if(dist < nearestD)
            {
                nearestD = dist;
                nearestB = optionBlocks.IndexOf(b);
            }
        }

        Debug.Log(nearestB);
        return nearestB;
    }

    void UseSkill(int bN, string skillName)
    {
        monster.UseSkill(skillName);

        foreach(Transform b in monster.currentSkill.transform)
        {
            b.gameObject.AddComponent<OBEnemy>();
        }

        monster.currentSkill.gameObject.transform.GetChild(bN).gameObject.GetComponent<OBEnemy>().Choosed();

        //monster.currentSkill.GetComponent<Skill>().childrens[b].GetComponent<OBPlayer>().CallAction();
        //monster.turnM.TurnEnd();

        //currentSkill = monster.currentSkill;
        //OBPlayer optionBlock =  monster.currentSkill.transform.GetChild(b).GetComponent<OBPlayer>();
        //optionBlock.CallAction();

        //choosedBlock = currentSkill.gameObject.transform.GetChild(b).gameObject;
        //monster.turnM.TurnEnd();
        //optionBlock = choosedBlock.GetComponent<OBPlayer>();
        //optionBlock.CallAction();
    }
}

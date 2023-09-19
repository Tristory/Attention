using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("Skill")]
    public GameObject shape;
    public string skillMovement;
    public string skillAttack;

    [Header("Stats")]
    public bool inTurn;
    public int hitPoint;

    public GameObject currentSkill;
    public BattleTurnManager turnM;

    void Start()
    {
        turnM = transform.parent.GetComponent<BattleTurnManager>();
    }

    void Update()
    {
        HealthManagement();
    }

    /*void SkillManagement()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UseSkill();
        }
        /*else if(Input.GetKeyDown(KeyCode.Backspace))
        {
            UseSkill(1);
        }
    }*/

    public void UseSkill(string skillName)
    {
        inTurn = false;

        //currentSkill = skills[i].gameObject;
        currentSkill = Instantiate(shape, transform);
        currentSkill.AddComponent(Type.GetType(skillName));
    }

    void HealthManagement()
    {
        if(hitPoint <= 0)
        {
            //turnM.monsters.Remove(this);
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MController : MonoBehaviour
{
    public Monster monster;

    void Start()
    {
        monster = gameObject.GetComponent<Monster>();
    }

    void Update()
    {
        if(monster.inTurn)
        {
            SkillManagement();
        }
    }

    void SkillManagement()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CallSkill("Movement");
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            CallSkill("Attack");
        }
    }

    void CallSkill(string skillName)
    {
            monster.UseSkill(skillName);

            foreach(Transform b in monster.currentSkill.transform)
            {
                b.gameObject.AddComponent<OBPlayer>();
            }
    }
}

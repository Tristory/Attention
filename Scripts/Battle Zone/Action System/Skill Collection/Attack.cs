using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Skill
{
    public void AttackAt(Collider2D target)
    {
        target.GetComponent<Monster>().hitPoint -= 4;
    }

    public override void Activate(Vector3 translation, Collider2D target)
    {
        target.GetComponent<Monster>().hitPoint -= 4;

        base.Activate(translation, target);
    }
}

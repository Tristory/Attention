using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public GameObject parent;
    public BattleTurnManager turnM;
    //public List<GameObject> childrens;

    void Start()
    {
        parent = transform.parent.gameObject;

        turnM = parent.GetComponent<Monster>().turnM;

        //ChildrenGetter();
    }

    /**void ChildrenGetter()
    {
        foreach(Transform b in transform)
        {
            childrens.Add(b.gameObject);
        }
    }*/

    public virtual void Activate(Vector3 translation, Collider2D target)
    {
        turnM.TurnEnd();
    }
}

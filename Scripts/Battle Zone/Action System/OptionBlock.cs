using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionBlock : MonoBehaviour
{
    public Skill currentSkill;

    public Collider2D _target;

    //public bool _collided;

    void Start()
    {
        currentSkill = transform.parent.GetComponent<Skill>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<Monster>())
        {
            //_collided = true;
            _target = other;
        }        
    }

    /*void OnTriggerExit2D(Collider2D other)
    {
        _collided = false;
    }*/

    //Call the skill from current skill
    public void CallAction()
    {
        /*if(_target == null)
        {
            //_target = new Collider2D();
            Debug.Log("Nothing here yet!");
        }*/

        currentSkill.Activate(transform.localPosition, _target);
        
        Destroy(currentSkill.gameObject);
    }
}

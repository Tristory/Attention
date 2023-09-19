using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBPlayer : OptionBlock
{
    public bool _hovered;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(_hovered)
            {
                CallAction();
            }            
        }
    }

    void OnMouseEnter()
    {
        _hovered = true;
    }

    void OnMouseExit()
    {
        _hovered = false;
    }
}

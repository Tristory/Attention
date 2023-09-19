using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBEnemy : OptionBlock
{
    bool _choosed;

    void Update()
    {
        if(_choosed)
        {
            _choosed = false;
            StartCoroutine(WaitForMoment());
        }
    }

    public void Choosed()
    {
        _choosed = true;

        /*if(_choosed)
        {
            _choosed = false;
            CallAction();
        }*/
    }

    IEnumerator WaitForMoment()
    {
        yield return new WaitForSeconds(.25f);
        
        CallAction();
    }
}

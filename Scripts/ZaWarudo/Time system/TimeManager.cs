using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public Act timechange;

    //public static int minute { get; private set; }
    //public static int hour { get; private set; }

    public WorldTime worldTime;

    public float minuteToRealTime;
    private float timer;

    void Start()
    {
        /*minute = 0;
        hour = 10;*/
        timer = minuteToRealTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            worldTime.minute++;

            if(worldTime.minute >= 60)
            {
                worldTime.hour++;

                if(worldTime.hour >= 24)
                {
                    worldTime.day++;

                    worldTime.hour = 0;
                }

                worldTime.minute = 0;
            }

            timechange.Raise();
            timer = minuteToRealTime;
        }
    }
}

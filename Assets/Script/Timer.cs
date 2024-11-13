using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer 
{
    float wait = 1;
    float counter = 0;

    public void SetTimer(float time)
    {
        wait = time;
        if (wait <= 0)
        {
            wait = 0.5f;
        }
        counter = wait;
    }

    public bool TimerActive()
    {
        if (counter > 0)
        {
            counter -= Time.deltaTime;
            return true;
        }
        else
        {
            return false;
        }
    }
}

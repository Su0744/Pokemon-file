using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer 
{
    float wait = 1;         // wait의 기본값 1
    float counter = 0;      //counter의 기본값 0

    public void SetTimer(float time)  // 기다리는 시간을 지정하는 메서드
    {
        wait = time;        // wait에 time값을 대입
        if (wait <= 0)      // wait가 0보다 작거나 같을시 true
        {
            wait = 0.5f;    // wait값을 0.5f로 (최소한의 시간을 지정)
        }
        counter = wait;     // counter에 wait값을 대입
    }

    public bool TimerActive() // 기다리는 시간이 남아있는지 안남아있는지 확인하는 메서드
    {
        if (counter > 0) // counter가 0보다 클시 true
        {
            counter -= Time.deltaTime;  // counter - time.deltatime의 값을 counter에 대입(만약 counter가 3일시 → 3-0.3(time.deltatime) counter = 2.7)
            return true;                // 해당조건문의 조건에 맞을시 무조건 true값을 줌.             
        }
        else // counter가 0보다 작거나 같을시 무조건 false값을 줌
        {
            return false;
        }
    }
}

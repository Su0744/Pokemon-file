using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer 
{
    float wait = 1;         // wait�� �⺻�� 1
    float counter = 0;      //counter�� �⺻�� 0

    public void SetTimer(float time)  // ��ٸ��� �ð��� �����ϴ� �޼���
    {
        wait = time;        // wait�� time���� ����
        if (wait <= 0)      // wait�� 0���� �۰ų� ������ true
        {
            wait = 0.5f;    // wait���� 0.5f�� (�ּ����� �ð��� ����)
        }
        counter = wait;     // counter�� wait���� ����
    }

    public bool TimerActive() // ��ٸ��� �ð��� �����ִ��� �ȳ����ִ��� Ȯ���ϴ� �޼���
    {
        if (counter > 0) // counter�� 0���� Ŭ�� true
        {
            counter -= Time.deltaTime;  // counter - time.deltatime�� ���� counter�� ����(���� counter�� 3�Ͻ� �� 3-0.3(time.deltatime) counter = 2.7)
            return true;                // �ش����ǹ��� ���ǿ� ������ ������ true���� ��.             
        }
        else // counter�� 0���� �۰ų� ������ ������ false���� ��
        {
            return false;
        }
    }
}

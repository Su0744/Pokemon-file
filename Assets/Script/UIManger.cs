using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    [SerializeField]
    Animator fadeScreen = null;             // �ʱⰪ�� ������ �ϵ� ������ �����
    public static UIManger instance;        // UIManger ��ũ��Ʈ�� �����ʿ���� ��밡���ϰ� �ϱ�

    private void Awake()                    // ��ũ��Ʈ ���ϸ��� instance�� ���ֱ��۾�
    {
        instance = this;
    }

    public void Fade(string AnimName)       // Fade�Լ��� AnimName �Ű����� �����("FadeIn","FadeOut" ���)
    {
        fadeScreen.Play(AnimName);          // fadeScreen�� ������ �󰪿� ���� �־��ִ� �۾�(Play = �ִϸ��̼� ����ϴ� �ڵ�)
    }
}

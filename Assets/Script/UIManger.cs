using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    [SerializeField]
    Animator fadeScreen = null;             // 초기값을 빈값으로 하되 공간만 만들기
    public static UIManger instance;        // UIManger 스크립트을 선언필요없이 사용가능하게 하기

    private void Awake()                    // 스크립트 제일먼저 instance에 값넣기작업
    {
        instance = this;
    }

    public void Fade(string AnimName)       // Fade함수에 AnimName 매개변수 만들기("FadeIn","FadeOut" 등등)
    {
        fadeScreen.Play(AnimName);          // fadeScreen을 가져와 빈값에 값을 넣어주는 작업(Play = 애니메이션 재생하는 코드)
    }
}

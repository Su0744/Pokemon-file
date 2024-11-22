using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interactable   // Interactable이라는 규칙을 지정
{
    public void Interact();     // 무조건 사용해야하는 규칙1(사용하지않을시 컴파일 오류)
}

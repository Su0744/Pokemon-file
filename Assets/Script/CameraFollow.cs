using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform target;                           //현재 위치 변수명
    void Start()
    {
        target = Move.instace.transform;        //move스크립트 위치 가져오기
    }

    private void LateUpdate()                   // 매프레임 마지막에 가져오는 메서드
    {
        if (target == null) return;             // 카메라에 타겟이 없을때 바로 종료시키는 코드
        transform.position = target.position;   // 카메라위치와 타겟 오브젝트를 같은 위치값으로 지정하는 코드
    }

}

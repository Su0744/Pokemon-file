using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform target;                           //���� ��ġ ������
    void Start()
    {
        target = Move.instace.transform;        //move��ũ��Ʈ ��ġ ��������
    }

    private void LateUpdate()                   // �������� �������� �������� �޼���
    {
        if (target == null) return;             // ī�޶� Ÿ���� ������ �ٷ� �����Ű�� �ڵ�
        transform.position = target.position;   // ī�޶���ġ�� Ÿ�� ������Ʈ�� ���� ��ġ������ �����ϴ� �ڵ�
    }

}

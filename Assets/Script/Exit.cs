using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [HideInInspector] // �����ڰ� ���Ӿȿ��� �����Ұ�
    public Transform spawnpoint; 
    public Exit destination;
    

    void Start()
    {
        spawnpoint = transform.GetChild(0); // ù��° �ڽĿ�����Ʈ�� ������
    }

    private void OnTriggerEnter2D(Collider2D collision) // �������� �ִ� �ݶ��̴�
    {
        if(collision.tag == "Player")
        {
            if(destination == null)
            {
                Debug.Log("���� ������ ����� �ʿ������ " + gameObject.name);
                return;
            }
            Move.instace.Teleport(destination);
        }
    }
}

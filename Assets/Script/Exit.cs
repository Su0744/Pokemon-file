using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [HideInInspector] // 개발자가 게임안에서 조정불가
    public Transform spawnpoint; 
    public Exit destination;
    

    void Start()
    {
        spawnpoint = transform.GetChild(0); // 첫번째 자식오브젝트를 가져옴
    }

    private void OnTriggerEnter2D(Collider2D collision) // 지나갈수 있는 콜라이더
    {
        if(collision.tag == "Player")
        {
            if(destination == null)
            {
                Debug.Log("지금 나갈수 없어요 필요아이템 " + gameObject.name);
                return;
            }
            Move.instace.Teleport(destination);
        }
    }
}

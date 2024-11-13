using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public static Move instace;
    public Timer timer = new Timer();

    [SerializeField] 
    float movespeed = 1; // 캐릭터 스피드
    Animator anima;
    Rigidbody2D rg;
    const float t_time = 0.3f;

    float x, y;

    private void Awake() // move클래스 가져오기 작업
    {
        instace = this;   
    }

    void Start()
    {
        anima = GetComponent<Animator>();
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 가로 세로의 즉각적인 움직임 부여
        if (timer.TimerActive())
        {
            transform.position += Vector3.zero;
            anima.SetBool("move", false);
            anima.SetFloat("x", x);
            anima.SetFloat("y", y);
            return;
        }

        float movex = Input.GetAxisRaw("Horizontal"); // 가로
        float movey = Input.GetAxisRaw("Vertical"); // 세로

        positionXY(movex, movey); // 움직였을때의 x,y축의 값을 positionXY 메소드에 보는 것


        var vertor = new Vector3(movex, movey, 0).normalized; // 해당 오브젝트 위치 부여 및 길이 1고정(그냥 위치방향만 잡히게)
        
        vertor *= movespeed * Time.deltaTime * 900; // 벡터 * movespeed * Time.deltaTime → 1로 고정된 길이에 movespeed와 time.deltaTime를 곱해서 속도 증가
        rg.velocity = vertor; // 해당 오브젝트위치와 vertor의 값을 더하는 것
        bool moveset = (movex != 0 || movey != 0);


        anima.SetBool("move",moveset);

        if (moveset) // 걷고있을때 유니티에 값 전달
        { 
            anima.SetFloat("movex", movex);
            anima.SetFloat("movey", movey);
        }
        else // 가만히 있을때의 유니티에 값 전달
        {
            anima.SetFloat("x", x);
            anima.SetFloat("y", y);
        }
    }


    void positionXY(float moveX, float moveY) // 걷다가 멈출때의 방향을 정하는 코드
    {
        if(moveX != 0) //가로축에서 멈췄을때 방향
        {
            x = moveX;
            y = 0;
        }
        else if(moveY != 0) // 세로축에서 멈췄을때 방향
        {
            x = 0;
            y = moveY;
        }
    }
 
    public void Teleport(Exit exit)
    {
        timer.SetTimer(t_time);
        transform.position = exit.spawnpoint.position; // 즉 현재위치를 나갈위치쪽으로 변경하는 코드
    }
}

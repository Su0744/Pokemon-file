using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public static Move instace;
    [SerializeField] 
    float movespeed = 1; // ĳ���� ���ǵ�
    Animator anima;
    Rigidbody2D rg;

    float x, y;

    private void Awake() // moveŬ���� �������� �۾�
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
        // ���� ������ �ﰢ���� ������ �ο�
        float movex = Input.GetAxisRaw("Horizontal"); // ����
        float movey = Input.GetAxisRaw("Vertical"); // ����

        positionXY(movex, movey); // ������������ x,y���� ���� positionXY �޼ҵ忡 ���� ��


        var vertor = new Vector3(movex, movey, 0).normalized; // �ش� ������Ʈ ��ġ �ο� �� ���� 1����(�׳� ��ġ���⸸ ������)
        
        vertor *= movespeed * Time.deltaTime * 1000; // ���� * movespeed * Time.deltaTime �� 1�� ������ ���̿� movespeed�� time.deltaTime�� ���ؼ� �ӵ� ����
        rg.velocity = vertor; // �ش� ������Ʈ��ġ�� vertor�� ���� ���ϴ� ��
        bool moveset = (movex != 0 || movey != 0);


        anima.SetBool("move",moveset);

        if (moveset) // �Ȱ������� ����Ƽ�� �� ����
        { 
            anima.SetFloat("movex", movex);
            anima.SetFloat("movey", movey);
        }
        else // ������ �������� ����Ƽ�� �� ����
        {
            anima.SetFloat("x", x);
            anima.SetFloat("y", y);
        }
    }


    void positionXY(float moveX, float moveY) // �ȴٰ� ���⶧�� ������ ���ϴ� �ڵ�
    {
        if(moveX != 0) //�����࿡�� �������� ����
        {
            x = moveX;
            y = 0;
        }
        else if(moveY != 0) // �����࿡�� �������� ����
        {
            x = 0;
            y = moveY;
        }
    }
 
    public void Teleport(Exit exit)
    {
        transform.position = exit.spawnpoint.position; // �� ������ġ�� ������ġ������ �����ϴ� �ڵ�
        Debug.Log("�ݺ� ����");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System.Linq;

public class Dialogue : MonoBehaviour, Interactable      // MonoBehaviour과 interactable 규칙을 가져옴 
{
    [SerializeField]
    Object textFile = null;             // object 변수만 만들고 값은 없음 (일단 데이터 타입을 정하지않아서 object하는것)

    [SerializeField]
    protected List<string> dialogue = new List<string>();       // 나 + 자식사용 변수 및 list 타입을 string로 만듬


    void Start()
    {
        if (textFile ==  null) return;      // textFile 값이 빈값일 경우 조건문 종료
        dialogue = File.ReadAllLines(AssetDatabase.GetAssetPath(textFile)).ToList();       //dialogue에 textFile안에 있는 값을 list로 변환시켜서 주는 코드
    }

    public void Interact()
    {

    }
}

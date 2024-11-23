using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System.Linq;

public class Dialogue : MonoBehaviour, Interactable      // MonoBehaviour�� interactable ��Ģ�� ������ 
{
    [SerializeField]
    Object textFile = null;             // object ������ ����� ���� ���� (�ϴ� ������ Ÿ���� �������ʾƼ� object�ϴ°�)

    [SerializeField]
    protected List<string> dialogue = new List<string>();       // �� + �ڽĻ�� ���� �� list Ÿ���� string�� ����


    void Start()
    {
        if (textFile ==  null) return;      // textFile ���� ���� ��� ���ǹ� ����
        dialogue = File.ReadAllLines(AssetDatabase.GetAssetPath(textFile)).ToList();       //dialogue�� textFile�ȿ� �ִ� ���� list�� ��ȯ���Ѽ� �ִ� �ڵ�
    }

    public void Interact()
    {

    }
}

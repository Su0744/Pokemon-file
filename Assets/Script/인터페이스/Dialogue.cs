using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System.Linq;

public class Dialogue : MonoBehaviour, Interactable
{
    [SerializeField]
    Object textFile = null;
    [SerializeField]
    protected List<string> dialogue = new List<string>();
    void Start()
    {
        if (textFile ==  null) return;
        dialogue = File.ReadAllLines(AssetDatabase.GetAssetPath(textFile)).ToList();
    }

    public void Interact()
    {

    }
}

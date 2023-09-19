using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StringChekcer : MonoBehaviour
{
    public string a;
    public string b;
    public TMP_InputField textMesh;

    public void WordChecker()
    {
        b = textMesh.text;
        Debug.Log(a == b);
    }
}

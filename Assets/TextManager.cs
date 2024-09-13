using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
        Invoke("ShowText", 3);
    }

    void ShowText()
    {
        text.SetActive(true);
    }
}

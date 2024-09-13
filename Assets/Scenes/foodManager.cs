using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class foodManager : MonoBehaviour
{
    public GameObject[] foods;
    public GameObject[] counts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFood(int id)
    {
        counts[id].GetComponent<TextMeshProUGUI>().text = (int.Parse(counts[id].GetComponent<TextMeshProUGUI>().text) + 1).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class foodManager : MonoBehaviour
{
    public GameObject[] foods;
    public GameObject[] counts;
    public String scene;
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
        if(int.Parse(counts[id].GetComponent<TextMeshProUGUI>().text) >= 5)
        {
            counts[id].GetComponent<TextMeshProUGUI>().color = Color.green;
        }
        if(int.Parse(counts[0].GetComponent<TextMeshProUGUI>().text) >= 5 && int.Parse(counts[1].GetComponent<TextMeshProUGUI>().text) >= 5 && int.Parse(counts[2].GetComponent<TextMeshProUGUI>().text) >= 5 && int.Parse(counts[3].GetComponent<TextMeshProUGUI>().text) >= 5 && int.Parse(counts[4].GetComponent<TextMeshProUGUI>().text) >= 5 && int.Parse(counts[5].GetComponent<TextMeshProUGUI>().text) >= 5)
        {
            SceneManager.LoadScene("youWin");
        }
    }
}

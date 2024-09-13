using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public void Transition(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

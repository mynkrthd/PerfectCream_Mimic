using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void NextScene(int index)
    {
        SceneManager.LoadScene(index);
        Time.timeScale = 1;
    }
}

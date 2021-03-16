using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOvermenu;

    private void Start()
    {
        GameOvermenu.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        GameOvermenu.SetActive(true);

    }
}

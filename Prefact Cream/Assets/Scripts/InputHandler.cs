using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject InfoUI;

    ParticleSystem creamDrops;
    float emmisionRate;
    public Transform _pipe;

    [System.Obsolete]
    private void Awake()
    {
        creamDrops = GetComponent<ParticleSystem>();
        emmisionRate = creamDrops.emissionRate;
      
        InfoUI.SetActive(true);
        Time.timeScale =0;
        
     
     
    }

    [System.Obsolete]
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("PLay");
          
            creamDrops.Play();
            creamDrops.enableEmission = true;
            if (InfoUI.active == true)
            {
                InfoUI.SetActive(false);
                Time.timeScale = 1;
            }
           

        }

        if (Input.GetMouseButton(0))
        {
            //Handheld.Vibrate();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("stop");
            
            creamDrops.enableEmission = false;
        }
    }

    private void OnDisable()
    {
        creamDrops.Clear();
    }
}

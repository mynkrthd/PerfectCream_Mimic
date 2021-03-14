using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    ParticleSystem creamDrops;
    private void Awake()
    {
        creamDrops = GetComponent<ParticleSystem>();
     

    }

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("PLay");
           
            creamDrops.Play();
        }

        if (Input.GetMouseButton(0))
        {
            //creamDrops.Play();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("stop");
            creamDrops.Pause();
        }
    }
}

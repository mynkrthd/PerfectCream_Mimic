using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
   
    void Start()
    {
        transform.position = Vector3.right * 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != -20)
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
    }
}

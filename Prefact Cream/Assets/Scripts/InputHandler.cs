using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    Emiter _emiter;
    private void Awake()
    {
        _emiter = GetComponent<Emiter>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _emiter.InitiateCream();
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Flow Continue");
        }

        if (Input.GetMouseButton(0))
        {
            _emiter.StopFlow();
        }
    }
}

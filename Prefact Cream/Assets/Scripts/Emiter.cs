using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emiter : MonoBehaviour
{
    public GameObject Cream;

    public GameObject currentCream;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InitiateCream()
    {
        currentCream = GameObject.Instantiate(Cream,transform.position,Quaternion.identity,transform);
    }

    public void ProduceCream()
    {

    }
    public void StopFlow()
    {
        Debug.Log(currentCream.gameObject.name.ToString());
       
    }
}

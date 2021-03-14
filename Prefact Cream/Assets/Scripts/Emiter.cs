using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emiter : MonoBehaviour
{
    public GameObject Cream;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InitiateCream()
    {
        GameObject.Instantiate(Cream,transform.position,Quaternion.identity);
    }

    public void StopFlow()
    {
        Debug.Log("End Flow");
       //gameObject.GetComponentInChildren<Rigidbody>().useGravity = true;
     
        
    }
}

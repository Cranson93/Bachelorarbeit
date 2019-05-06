using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update
 
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(Cube);
    }

   
}

   


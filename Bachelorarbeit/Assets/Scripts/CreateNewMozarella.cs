using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewMozarella : MonoBehaviour
{

    [SerializeField] private GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
           Instantiate(food); 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

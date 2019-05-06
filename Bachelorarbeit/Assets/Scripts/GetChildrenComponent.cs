using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildrenComponent : MonoBehaviour
{

    public BoxCollider[] boxCols;

    // Start is called before the first frame update
    void Start()
    {
        boxCols = GetComponentsInChildren<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

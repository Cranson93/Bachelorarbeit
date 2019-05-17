using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayListener : MonoBehaviour
{
    [SerializeField] private GameObject display;

    public void MyPointerEnter()
    {
      //  GetComponent<Renderer>().material.color = Color.white;
            display.SetActive(true);
            //   productInfo.gameObject.SetActive(true);
        }


     public void MyPointerLeave()
        {
                display.SetActive(false);
                //    productInfo.gameObject.SetActive(false);
            
        }
    }


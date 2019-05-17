using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayListener : MonoBehaviour
{
    [SerializeField] private GameObject display;

    private void MyPointerEnter()
    {
            display.SetActive(true);
            //   productInfo.gameObject.SetActive(true);
        }


     private void MyPointerLeave()
        {
                display.SetActive(false);
                //    productInfo.gameObject.SetActive(false);
            
        }
    }


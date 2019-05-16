using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayListener : MonoBehaviour
{
    [SerializeField] private GameObject display;

    private void MyPointerEnter(Camera gaze)
    {
        if (gaze.gameObject.CompareTag("Player"))
        {
            display.SetActive(true);
            //   productInfo.gameObject.SetActive(true);
        }


        void MyPointerLeave()
        {
            if (gaze.gameObject.CompareTag("Player"))
            {
                display.SetActive(false);
                //    productInfo.gameObject.SetActive(false);
            }
        }
    }
}

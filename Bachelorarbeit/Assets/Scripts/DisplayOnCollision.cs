using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayOnCollision : MonoBehaviour
{
    [SerializeField] private GameObject display;
   // [SerializeField] private TextMesh productInfo;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            display.SetActive(true);
         //   productInfo.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            display.SetActive(false);
        //    productInfo.gameObject.SetActive(false);
        }
    }
    
}
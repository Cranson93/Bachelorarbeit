using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayOnCollision : MonoBehaviour
{
    [SerializeField] private GameObject display;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            display.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            display.SetActive(false);
        }
    }
}
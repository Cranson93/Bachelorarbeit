using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductDisplay : MonoBehaviour
{
    public Product product;
    public Text txt_product; 

   public void Start()
    {
        txt_product.text = product.nameProd;

    }
}

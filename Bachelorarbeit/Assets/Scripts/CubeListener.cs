using UnityEngine;
using System.Collections;

public class CubeListener : MonoBehaviour
{
	[SerializeField] private GameObject text;
	public void MyPointerEnter () 
	{
		GetComponent<Renderer>().material.color = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), 1.0f);
		text.SetActive(true);
	}

	public void MyPointerLeave ()
	{
		GetComponent<Renderer>().material.color = Color.white;
		text.SetActive(false);
	}
}

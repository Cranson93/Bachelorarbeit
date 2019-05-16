using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

public class VisionRaycast : MonoBehaviour {

    public Collider player; // holds a reference to the player camera

    void Start () {
	    
    }
	
    void Update () {
        RaycastHit hit = new RaycastHit(); // this object will collect data about the collision each frame

        if (Physics.Raycast(player.transform.position, player.transform.forward, out hit)) // do the raycast, based on the camera's position and orientation, and store the hit for our reference
        {
            Debug.Log("We are hitting something!"); // the raycast collided with an object
        }
        else // there wasn't any collision
        {
            Debug.Log("Not hitting anything.");
        }
    }
}


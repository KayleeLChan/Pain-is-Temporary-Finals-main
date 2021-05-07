using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformInvisible : MonoBehaviour
{
    public string message;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Invisible")
        {
            Debug.Log("Looks like something is in the way...");
        }
    }
}
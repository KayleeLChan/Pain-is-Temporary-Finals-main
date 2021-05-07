using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseStep : MonoBehaviour
{
    public GameObject respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Change respawn point
            other.GetComponent<PlayerFallWarp>().warpPoint = respawn;

            //Inform player of checkpoint
            Debug.Log("Oops! Must have slipped!");
        }
    }
}

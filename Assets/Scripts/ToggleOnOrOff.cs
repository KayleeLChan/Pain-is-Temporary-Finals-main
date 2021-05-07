using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOrOff : MonoBehaviour
{
    public GameObject objectToToggle;
    public bool toggled;

    void Start()
    {
        toggled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(!toggled && other.gameObject.tag == "Player")
        {
            if(objectToToggle.active == true)
            {
                objectToToggle.SetActive(false);
            }
            else
            {
                objectToToggle.SetActive(true);
            }

            //Make it so that it cannot be toggled again
            toggled = true;
            Debug.Log("Did something just happen right then?");
        }
    }
}

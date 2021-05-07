using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightTimer : MonoBehaviour
{

    new Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        controlLights();
    }

    void controlLights()
    {
        StartCoroutine(ToggleLightOn(35));
        StartCoroutine(ToggleLightOff(56));
        StartCoroutine(ToggleLightOn(61));
        StartCoroutine(ToggleLightOff(84));
    }

    IEnumerator ToggleLightOn(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        light.enabled = true;
    }

    IEnumerator ToggleLightOff(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        light.enabled = true;
    }
}

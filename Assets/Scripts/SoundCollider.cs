using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollider : MonoBehaviour
{
    public AudioSource audioClip;

    public bool playable;
    public bool nextStepAvailable;

    public Light andreLight;
    public Light natashaLight;
    public Light sonyaLight;
    public Light maryaLight;
    public Light anatoleLight;
    public Light heleneLight;
    public Light dolokhovLight;
    public Light bolkonskyLight;
    public Light maryLight;
    public Light balagaLight;

    public Light lineLightLeft;
    public Light lineLightRight;

    private void Start()
    {
        playable = false;
        nextStepAvailable = false;
        audioClip = GetComponent<AudioSource>();
    }

    //Play attached clip when Player collides with character
    private void OnTriggerEnter(Collider other)
    {
        if (playable == true && other.gameObject.tag == "Player")
        {
            PlayClip();
            nextStepAvailable = true;
            TimeLights();
        }
    }

    //Prevent audio spamming
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playable = false;
        }
    }

    void PlayClip()
    {
        audioClip.Play();
    }

    //Sync lights to music
    void TimeLights()
    {
        if (gameObject.tag == "Intro")
        {
            ControlAndre(andreLight);
            ControlSpotights(natashaLight);
            ControlSpotights(sonyaLight);
            ControlSpotights(maryaLight);
            ControlSpotights(anatoleLight);
            ControlSpotights(heleneLight);
            ControlSpotights(dolokhovLight);
            ControlSpotights(bolkonskyLight);
            ControlSpotights(maryLight);
            ControlSpotights(balagaLight);
            ControlSpotights(lineLightLeft);
            ControlSpotights(lineLightRight);
        }
        else if(gameObject.tag == "Natasha")
        {
            CustomControl(0, 11, natashaLight);
        }
        else if(gameObject.tag == "Sonya")
        {
            CustomControl(0, 7, sonyaLight);
        }
        else if (gameObject.tag == "Marya")
        {
            CustomControl(0, 9, maryaLight);
        }
        else if (gameObject.tag == "Anatole")
        {
            CustomControl(0, 34, anatoleLight);
        }
        else if (gameObject.tag == "Helene")
        {
            CustomControl(0, 7, heleneLight);
        }
        else if (gameObject.tag == "Dolokhov")
        {
            CustomControl(0, 9, dolokhovLight);
        }
        else if (gameObject.tag == "Bolkonsky")
        {
            CustomControl(0, 12, bolkonskyLight);
        }
        else if (gameObject.tag == "Mary")
        {
            CustomControl(0, 14, maryLight);
        }
        else if (gameObject.tag == "Balaga")
        {
            CustomControl(0, 22, balagaLight);
        }
    }

    void ControlAndre(Light light)
    {
        StartCoroutine(ToggleLightOff(56, light));
        StartCoroutine(ToggleLightOn(61, light));
    }

    void ControlSpotights(Light light)
    {
            StartCoroutine(ToggleLightOn(35, light));
            StartCoroutine(ToggleLightOff(56, light));
            StartCoroutine(ToggleLightOn(61, light));
    }

    void CustomControl(float waitOn, float waitOff, Light light)
    {
        StartCoroutine(ToggleLightOn(waitOn, light));
        StartCoroutine(ToggleLightOff(waitOff, light));
    }

    IEnumerator ToggleLightOn(float waitTime, Light light)
    {
        yield return new WaitForSeconds(waitTime);
        light.enabled = true;
    }

    IEnumerator ToggleLightOff(float waitTime, Light light)
    {
        yield return new WaitForSeconds(waitTime);
        light.enabled = true;
    }
}

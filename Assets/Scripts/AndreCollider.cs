using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndreCollider : MonoBehaviour
{
    public AudioSource audioClip;

    public GameObject objectToToggle;

    public bool toggled;
    public bool playable;
    public bool nextStepAvailable;

    private void Start()
    {
        playable = false;
        nextStepAvailable = false;
        toggled = false;

        audioClip = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Play attached clip when Player collides with character
        if (playable == true && other.gameObject.tag == "Player")
        {
            PlayClip();

            nextStepAvailable = true;

            //Activate next Andre and deactive current Andre
            if (!toggled)
            {
                if (objectToToggle.active == true)
                {
                    objectToToggle.SetActive(false);
                }
                else
                {
                    objectToToggle.SetActive(true);
                }

                //Make it so that it cannot be toggled again
                toggled = true;
                DelayRemoval();
            }
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

    void DelayRemoval()
    {
        StartCoroutine(RemoveAndre());
    }

    //Wait for Andre's audio clip to finish
    IEnumerator RemoveAndre()
    {
        if(gameObject.tag == "Finish")
        {
            yield return new WaitForSeconds(23f);
            gameObject.SetActive(false);
        }
        else
        {
            yield return new WaitForSeconds(4f);
            gameObject.SetActive(false);
        }
    }
}

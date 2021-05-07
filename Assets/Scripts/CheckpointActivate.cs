using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointActivate : MonoBehaviour
{
    public AudioSource audioClip;
    public ParticleSystem checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GetComponent<ParticleSystem>();
        audioClip = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //Change respawn point
            other.GetComponent<PlayerFallWarp>().warpPoint = gameObject;

            //Play particle and sound effect
            checkpoint.Play();
            audioClip.Play();
            
            //Inform player of checkpoint
            Debug.Log("Checkpoint Reached!");
        }
    }
}

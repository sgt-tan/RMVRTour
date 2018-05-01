using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour {
    public bool enter;
    public AudioClip AudioClip;
    private AudioSource source;
    private bool played;

    // Use this for initialization
    void Start()
    {
        enter = false;
        played = false;
        source = GameObject.Find("FPSController").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && played == false)
        {
            enter = true;
            played = true;
            // Play the sound only on the trigger
            source.Stop();
            source.PlayOneShot(AudioClip);
        }
        Debug.Log("Entered");
    }

    //Deactivate the Main function when player is go away from AudioClip spot
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
            played = false;
        }
        Debug.Log("Exited");
    }
}

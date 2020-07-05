using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTones2 : MonoBehaviour
{
    public AudioSource tone;
    public AudioClip[] audios;
    public Boolean trigger = false;
    void Start()
    {
        this.GetComponent<AudioSource>().clip = audios[0];
        //StartCoroutine(playaudio(2));
    }

    // Update is called once per frame
    void Update()
    {
        /*if (trigger)
        {
            tone.loop = true;
            
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floors")
        {
            /*trigger = true;
            tone.loop = true;
            tone.Play();*/
            this.GetComponent<AudioSource>().Play();
            this.GetComponent<AudioSource>().clip = audios[1];
            this.GetComponent<AudioSource>().clip = audios[0];
        }
    }

    IEnumerator playaudio(float time)
    {
        yield return new WaitForSeconds(time);

        tone.Play();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTones : MonoBehaviour
{
    public AudioSource tone;
    public Boolean trigger = false;
    public int hitcount = 0;
    void Start()
    {
        tone = GetComponent<AudioSource> ();
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
            hitcount++;
            if (hitcount>1)
            {
                tone.Play();
            }
            
        }
    }

    IEnumerator playaudio(float time)
    {
        yield return new WaitForSeconds(time);

        tone.Play();
    }
}

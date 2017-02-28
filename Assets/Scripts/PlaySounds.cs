using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour {

    public bool hoverObject = false;
    public GameObject[] listofSounds;
    public Material lightUpMaterial;
    public Material defaultMaterial;

    int soundindex=0;
    bool active = false;

	// Use this for initialization
	void Start () {
        
        

    }


    public void playSounds()
    {
        active = !active;
        if (!active)
        {
            stopSound();
            return;
        }
        else
            playSound();

    }


    public void playSound()
    {
        
        if (!active)
        {
            stopSound();
            return;
        }


        if (hoverObject)
            listofSounds[soundindex].GetComponent<MeshRenderer>().material = defaultMaterial; //Assign the hover material

        listofSounds[soundindex].GetComponent<AudioSource>().Stop();

        soundindex = (soundindex + 1) % listofSounds.Length;
        if (hoverObject)
            listofSounds[soundindex].GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material

        listofSounds[soundindex].GetComponent<AudioSource>().Play();

        Invoke("playSound", listofSounds[soundindex].GetComponent<AudioSource>().clip.length);
        

        

    }

    public void stopSound()
    {

        CancelInvoke("playSound");

        if (hoverObject)
            listofSounds[soundindex].GetComponent<MeshRenderer>().material = defaultMaterial; //Assign the hover material

        listofSounds[soundindex].GetComponent<AudioSource>().Stop();
    }

    // Update is called once per frame
    void Update () {
		
	}
}

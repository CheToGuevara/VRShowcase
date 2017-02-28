using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovie : MonoBehaviour {

    public GameObject screen;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
   
    public void StartMovie()
    {
         

            Renderer r = screen.GetComponent<Renderer>();
        /*MovieTexture movie;
        movie = (MovieTexture)r.material.mainTexture;

            if (movie.isPlaying)
            {
                movie.Pause();
            }
            else
            {
                movie.Play();
            }*/
        
    }

}

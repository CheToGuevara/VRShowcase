using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    public GameObject player;
    public GameObject startUI, restartUI;
    public Transform[] enterWaypoints;
    public Transform[] exitWaypoints;

    

    // Use this for initialization
    void Start()
    {
        //player.transform.position = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startPuzzle()
    { //Begin the puzzle sequence
        //toggleUI();

        
        iTween.MoveTo(player,
            iTween.Hash(
                "path", enterWaypoints,
                "time", 2,
                "easetype", "linear"
            )
        );
        toggleUI();
        AudioSource mysound = GetComponent<AudioSource>();
        if (mysound)
            mysound.Play();
    }


    public void puzzleSuccess()
    { //Do this when the player gets it right
        iTween.MoveTo(player,
           iTween.Hash(
               "path", exitWaypoints,
               "time", 2,
               "easetype", "linear"
           )
       );
        toggleUI();
        AudioSource mysound = GetComponent<AudioSource>();
        if (mysound)
            mysound.Stop();
    }
    public void toggleUI()
    {
        startUI.SetActive(!startUI.activeSelf);
        restartUI.SetActive(!restartUI.activeSelf);
    }

}
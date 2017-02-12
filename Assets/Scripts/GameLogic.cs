using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    public GameObject player;
    public GameObject startUI, restartUI;
    public GameObject startPoint, playPoint, restartPoint;

    public GameObject doorL, doorR;
    public GameObject startL, endL, startR, endR;

    public bool playerWon = false;

    // Use this for initialization
    void Start()
    {
        player.transform.position = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && player.transform.position == playPoint.transform.position)
        {
            //puzzleSuccess();
        }
    }

    public void startPuzzle()
    { //Begin the puzzle sequence
        //toggleUI();
        iTween.MoveTo(player,
            iTween.Hash(
                "position", playPoint.transform.position,
                "time", 2,
                "easetype", "linear"
            )
        );
        startUI.SetActive(!startUI.activeSelf);
    }

    public void resetPuzzle()
    { //Reset the puzzle sequence
        player.transform.position = startPoint.transform.position;
        toggleUI();

        iTween.MoveTo(doorL,
            iTween.Hash(
                "position", startL.transform.position,
                "time", 0.1,
                "easetype", "linear"
            )
        );
        iTween.MoveTo(doorR,
            iTween.Hash(
                "position", startR.transform.position,
                "time", 0.1,
                "easetype", "linear"
            )
        );
    }


    public void puzzleSuccess()
    { //Do this when the player gets it right
        iTween.MoveTo(player,
            iTween.Hash(
                "position", restartPoint.transform.position,
                "time", 2,
                "easetype", "linear"
            )
        );

        iTween.MoveTo(doorL,
            iTween.Hash(
                "position", endL.transform.position,
                "time", 2,
                "easetype", "linear"
            )
        );
        iTween.MoveTo(doorR,
            iTween.Hash(
                "position", endR.transform.position,
                "time", 2,
                "easetype", "linear"
            )
        );
        restartUI.SetActive(!restartUI.activeSelf);
    }
    public void toggleUI()
    {
        startUI.SetActive(!startUI.activeSelf);
        restartUI.SetActive(!restartUI.activeSelf);
    }

}
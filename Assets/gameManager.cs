using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] walls;
    public GameObject[] UIs;
    public GameObject[] puzzles;
    public GameObject[] puzzlesUIs;
    public GameObject FlaverText;

    public GameObject[] sounds;

    public bool Wall1Complete;
    public bool Wall2Complete;
    public bool Wall3Complete;



    float mousex = 0f;
    float mousey = 0f;


    // Start is called before the first frame update
    void Start()
    {
        walls[0].SetActive(true);
        UIs[0].SetActive(true);

    }




    // Update is called once per frame
    void Update()
    {
        //Vector3 mouse = Input.mousePosition;
        // Get the mouse delta. This is not in the range -1...1
        mousex = Input.mousePosition.x;
        mousey = Input.mousePosition.y;
        //Debug.Log("x:" + mousex + " y:" + mousey);


        if (walls[0].activeSelf == true )
        {
            UIs[1].SetActive(true);
            sounds[0].GetComponent<AudioSource>().mute = false;
        }
        else
        {
            UIs[1].SetActive(false);
            sounds[0].GetComponent<AudioSource>().mute = true;
        }

        if(walls[1].activeSelf == true || puzzles[1].activeSelf == true)
        {
            
            sounds[1].GetComponent<AudioSource>().mute = false;
        }
        else
        {
            sounds[1].GetComponent<AudioSource>().mute = true;
        }
        /*
        if (walls[1].activeSelf == true)
        {
            UIs[2].SetActive(true);
        }
        if (walls[3].activeSelf == true)
        {
            UIs[2].SetActive(true);
        }
        if (walls[4].activeSelf == true)
        {
            UIs[3].SetActive(true);
        }
        */
    }


    // switching walls
    public void  PressLeftButton()
    {
        
        if (walls[0].activeSelf == true)
        {
            walls[0].SetActive(false);
            walls[3].SetActive(true);
            
        }

        else if (walls[3].activeSelf == true)
        {
            walls[3].SetActive(false);
            walls[2].SetActive(true);
        }

        else if (walls[2].activeSelf == true)
        {
            walls[2].SetActive(false);
            walls[1].SetActive(true);
        }

        else if (walls[1].activeSelf == true)
        {
            walls[1].SetActive(false);
            walls[0].SetActive(true);
        }

    }

    public void PressRightButton()
    {

        if (walls[0].activeSelf == true)
        {
            walls[0].SetActive(false);
            walls[1].SetActive(true);
        }

        else if (walls[1].activeSelf == true)
        {
            walls[1].SetActive(false);
            walls[2].SetActive(true);
        }

        else if (walls[2].activeSelf == true)
        {
            walls[2].SetActive(false);
            walls[3].SetActive(true);
        }

        else if (walls[3].activeSelf == true)
        {
            walls[3].SetActive(false);
            walls[0].SetActive(true);
        }

    }



    // wall1 interactive objects and scenes

    public void ClockPressed()
    {
        if(walls[0].activeSelf == true)
        {
            Debug.Log("clockpuzzle");
            puzzles[0].SetActive(true);
            puzzlesUIs[0].SetActive(true);
            walls[0].SetActive(false);
            UIs[0].SetActive(false);
            

        }
    }



    public void NotePressed()
    {
        if (walls[0].activeSelf == true)
        {
            //Debug.Log("note");
        }
    }



    // puzzles interaction button codes

    public void ClockPuzzleExit()
    {
        puzzles[0].SetActive(false);
        puzzlesUIs[0].SetActive(false);
        walls[0].SetActive(true);
        UIs[0].SetActive(true);
        
    }

    public void ClockPuzzleComplete()
    {

    }





    //Wall2

    public void ShapePuzzleEnter()
    {
        walls[1].SetActive(false);
        puzzles[1].SetActive(true);
        UIs[0].SetActive(false);
    }

    public void ShapePuzzleExit()
    {
        walls[1].SetActive(true);
        puzzles[1].SetActive(false);
        UIs[0].SetActive(true);
    }

    //Wall3
    public void SafePuzzleEnter()
    {

    }

    public void SafePuzzleExit()
    {
        walls[2].SetActive(true);
        puzzles[2].SetActive(false);
        UIs[0].SetActive(true);
    }

}

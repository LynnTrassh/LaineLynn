using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseOver : MonoBehaviour
{
    public GameObject FlavorText;
    public TextMeshProUGUI Text;
    public GameObject gameManager;





    

    //Wall 1
    public bool PictureOnWall;
    public bool Note;
    public bool Clock;
    public bool Wine;


    //changes made
    public bool glassfull = false;
    public bool glasswithflower = false;


    //Wall2
    public bool ShapePuzzleEnterIcon;
    public bool ShapePuzzleExit;
    public bool MissingPuzzle;
    public bool chaxianban;
    public bool noteinthesmallcloset;
    public bool radio;
    public GameObject Radio;
   


    // changes made
    public bool ShapePuzzleReadyToSolve = false;
    public bool ShapePuzzleComplete = false;
    public GameObject CoverTheWall;
    public GameObject ElectricCord;
    public bool pluggedin;
    public AudioSource radiosound;
    public AudioClip radionews;


    //wall 3

    //in puzzle
    public bool SafePuzzleExit;
    
    








    // Start is called before the first frame update
    void Start()
    {
        FlavorText.SetActive(false);
        Text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        FlavorText.SetActive(true);

        

        if (PictureOnWall)
        {
            Text.text = "What a lovely couple.";
        }

        if(Note)
        {
            Text.text = "'Hey hon, I should be home at 9:00. - Love, Julie.'";
        }
        

        if (Clock)
        {
            Text.text = "The clock is not functioning.";
        }
        if (Wine && !glassfull)
        {
            Text.text = "Empty vase.";
        }
        else if(Wine && glassfull && !glasswithflower)
        {
            Text.text = "Vase is filled up with water.";
        }
        else if(Wine && glassfull && glasswithflower)
        {
            Text.text = "Flower is flourishing in the water";
        }

        // Wall 2

        if (ShapePuzzleEnterIcon && !ShapePuzzleReadyToSolve && !ShapePuzzleComplete)
        {
            
            FlavorText.SetActive(true);
            Text.text = "A piece of the puzzle is missing.";
        }
        else if(ShapePuzzleEnterIcon && ShapePuzzleReadyToSolve && !ShapePuzzleComplete)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }
        else if (ShapePuzzleEnterIcon && ShapePuzzleReadyToSolve && ShapePuzzleComplete)
        {
            Text.text = "A picture of a girl playing piano.";
            Radio.GetComponent<MouseOver>().ShapePuzzleComplete = true;
        }


        if (ShapePuzzleExit)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }

        if(MissingPuzzle)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }
        if(chaxianban)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }
        if(noteinthesmallcloset)
        {
            FlavorText.SetActive(true);
            Text.text = "'Hey hon, the radio is not working. Could u fix it before I come home today?'";
        }

        if(radio || SafePuzzleExit)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }

    }

    public void OnMouseExit()
    {
        FlavorText.SetActive(false);
        Text.text = "";
    }

    public void OnMouseDown()
    {
        if(Clock)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }

        if(ShapePuzzleEnterIcon)
        {
            if (ShapePuzzleReadyToSolve == true)
            {
                gameManager.SendMessage("ShapePuzzleEnter");
                FlavorText.SetActive(false);
                Text.text = "";
            }
            else
            {

            }
        }

        if(ShapePuzzleExit)
        {
            gameManager.SendMessage("ShapePuzzleExit");
        }
        
        if(chaxianban)
        {
            CoverTheWall.GetComponent<SpriteRenderer>().enabled = true;
            ElectricCord.GetComponent<SpriteRenderer>().enabled = true;
            Radio.GetComponent<MouseOver>().pluggedin = true;
        }
        if(radio)
        {
            
            
            if(!radiosound.isPlaying && ShapePuzzleComplete && pluggedin)
                {

                    radiosound.PlayOneShot(radionews);
                    
                }

        }

        if(SafePuzzleExit)
        {
            gameManager.SendMessage("SafePuzzleExit");
        }

        
        
    }

    /*public void OnMouseDrag()
    {
        if (Wine)
        {
            if (transform.position != new Vector3(-3f, -1.25f, 0f)) ;
            {
                FlavorText.SetActive(false);
                Text.text = "";
            }
            
        }
    }
    */


    ///




}

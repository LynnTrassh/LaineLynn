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
    public GameObject notesprite;
    public bool NoteSprite;


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
    public bool openbigcloset;
    
    public bool smallbox;
    public bool closedsafe;
    public GameObject ClosedSafe;
    public GameObject OpenSafe;
    public GameObject Smallbox;
    public GameObject key;
    
    

    //in puzzle
    public bool SafePuzzleExit;

    //changes made
    public bool bigclosetopen = false;
    public bool bigclosetunlocked = false;
    public bool keygot = false;
    public bool safeopen = false;

    public bool safeunclocked;
    public bool diaryopen;

    //wall 4
    public bool papers;
    public GameObject candle1;
    public GameObject candle2;
    public bool candle1flaming = false;
    public bool candle2flaming = false;
    public GameObject wall4;
    public GameObject[] darkfilters;
    public GameObject clocksprite;
    public GameObject PaperOnDesk;












    // Start is called before the first frame update
    void Start()
    {
        FlavorText.SetActive(false);
        Text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(safeunclocked)
        {
            ClosedSafe.SetActive(false);
            if (bigclosetopen)
            {
                OpenSafe.SetActive(true);
            }
            
        }

        if(papers)
        {
            if (candle1.GetComponent<SpriteRenderer>().enabled == true)
            {
                candle1flaming = true;
            }
            if (candle2.GetComponent<SpriteRenderer>().enabled == true)
            {
                candle2flaming = true;
            }

            if (candle1flaming == true && candle2flaming == true)
            {
                darkfilters[0].SetActive(false);
                darkfilters[1].SetActive(false);
                darkfilters[2].SetActive(false);
                darkfilters[3].SetActive(false);
                clocksprite.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
        
    }

    public void OnMouseOver()
    {
        

        

        if (PictureOnWall)
        {
            Text.text = "What a lovely couple.";
            FlavorText.SetActive(true);
        }

        if(Note)
        {
            FlavorText.SetActive(true);
            Text.text = "Someone left a note";
            notesprite.SetActive(true);
            
        }
        

        if (Clock)
        {
            Text.text = "The clock is not functioning.";
            FlavorText.SetActive(true);
        }
        if (Wine && !glassfull)
        {
            Text.text = "Empty vase.";
            FlavorText.SetActive(true);
        }
        else if(Wine && glassfull && !glasswithflower)
        {
            Text.text = "Vase is filled up with water.";
            FlavorText.SetActive(true);
        }
        else if(Wine && glassfull && glasswithflower)
        {
            Text.text = "Flower is flourishing in the water";
            FlavorText.SetActive(true);
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

        if(openbigcloset && !bigclosetopen)
        {
            FlavorText.SetActive(true);
            Text.text = "Closet locked";
        }
        else if(openbigcloset && bigclosetopen)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }
        if(closedsafe || OpenSafe || smallbox)
        {
            FlavorText.SetActive(false);
            Text.text = "";
        }

        if(papers)
        {
            if(candle1flaming && candle2flaming)
            {
                FlavorText.SetActive(false);
                Text.text = "";
            }
            else
            {
                FlavorText.SetActive(true);
                Text.text = "Need more light to read";
            }
            
        }
        if (notesprite)
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

        /*if(Note)
        {
            FlavorText.SetActive(false);
            Text.text = "";
            notesprite.SetActive(true);
            Debug.Log("working");

        }
        */
        if(notesprite)
        {
            FlavorText.SetActive(false);
            Text.text = "";
            notesprite.SetActive(false);
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

                    radiosound.PlayOneShot(radionews,3.5f);
                gameManager.GetComponent<gameManager>().radiocomplete = true;
                    
                }

        }

        if(SafePuzzleExit)
        {
            gameManager.SendMessage("SafePuzzleExit");
        }

        if(openbigcloset)
        {
            if(!bigclosetopen && bigclosetunlocked)
            {
                FlavorText.SetActive(false);
                Text.text = "";
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                bigclosetopen = true;
                if (!safeunclocked)
                {
                    ClosedSafe.SetActive(true);
                    OpenSafe.SetActive(false);
                }
                else
                {
                    ClosedSafe.SetActive(false);
                    OpenSafe.SetActive(true);
                }
                
            }
            else if(bigclosetopen && bigclosetunlocked)
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                bigclosetopen = false;

                ClosedSafe.SetActive(false);
                OpenSafe.SetActive(false);
            }
            
        }
        if(closedsafe && !safeopen)
        {
            gameManager.SendMessage("SafePuzzleEnter");
            Debug.Log("clicking");
        }
        if(ClosedSafe && safeunclocked)
        {
            ClosedSafe.SetActive(false);
            //OpenSafe.SetActive(true);
        }

        if(smallbox)
        {
            if(Smallbox.GetComponent<SpriteRenderer>().enabled == false)
            {
                Smallbox.GetComponent<SpriteRenderer>().enabled = true;
                key.SetActive(true);
            }
            
            
        }

        if(papers)
        {
            if(candle1flaming && candle2flaming)
            {
                wall4.SetActive(false);
                PaperOnDesk.SetActive(true);
                
            }
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

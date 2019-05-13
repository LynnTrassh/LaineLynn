using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour
{

    private Vector3 click;
    public bool vase;
    public bool flower;
    public bool waterfilled = false;
    //wall 2
    public bool MissingPuzzle;

    //wall1
    public GameObject Vase;
    public GameObject Flower;
    //wall 2
    public GameObject ShapePuzzleEnter;
    public GameObject smallcloset;

    public float SnapDistance;

    //wall 3
    public bool key;
    public GameObject BigCloset;
    public AudioSource soundeffect;
    public AudioClip closetunlocksound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void OnMouseDown()
    {
        click = gameObject.transform.position -
           Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    public void OnMouseDrag()
    {
        Vector3 newPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + click;




        if(vase && !waterfilled)
        {
            float distance = Vector3.Distance(new Vector3(6.32f, -1.22f, 0), Vase.transform.position);
            if (distance < SnapDistance)
            {
                    gameObject.SendMessage("ChangeSprite");
                    waterfilled = true;
                    Flower.GetComponent<ClickDrag>().waterfilled = true;
                    Vase.GetComponent<MouseOver>().glassfull = true;



            }
        }

        if (MissingPuzzle)
        {
            float distance = Vector3.Distance(this.gameObject.transform.position, ShapePuzzleEnter.transform.position);
            if (distance < SnapDistance)
            {
                Destroy(gameObject);
                smallcloset.GetComponent<OpenCloseCloset>().puzzeldestroyed = true;
                ShapePuzzleEnter.GetComponent<ShapePuzzleChangeSprite>().puzzlereadytosolve = true;


            }
            else
            {
                //transform.position = new Vector3(-4.73f, -4.17f, 0);
            }
        }
    }

    public void OnMouseUp()
    {
        if(vase)
        {

            
            transform.position = new Vector3(-3f, -1.25f, 0f);
        }

        if(flower)
        {
            if(!waterfilled)
            {
                transform.position = new Vector3(-5.17f, -2.8f, 0f);
            }
            else
            {
                float distance = Vector3.Distance(Flower.transform.position, Vase.transform.position);
                if (distance < SnapDistance  )
                {
                    Destroy(gameObject);
                    Vase.SendMessage("AddFlower");
                    Vase.GetComponent<MouseOver>().glasswithflower = true;
                }
            }
            
        }
        if(key)
        {
            float distance = Vector3.Distance(this.gameObject.transform.position, BigCloset.transform.position);
            if (distance < SnapDistance)
            {
                Destroy(gameObject);
                BigCloset.GetComponent<MouseOver>().bigclosetunlocked = true;
                soundeffect.PlayOneShot(closetunlocksound,2.5f);
                
            }
            else
            {
                transform.position = new Vector3(5.606663f, 0.09828165f, 0f);
            }
        }
        
    }

    


}

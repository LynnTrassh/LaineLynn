using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseCloset : MonoBehaviour
{
    public bool Wall2Closet;
    public bool open = false;
    public bool puzzeldestroyed = false;
    public GameObject note;
    public GameObject puzzle;

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
        if(!open)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            open = true;
            note.SetActive(true);
            if(!puzzeldestroyed)
            {
                puzzle.SetActive(true);
            }
            
        }
        else if(open)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            open = false;
            note.SetActive(false);
            if (!puzzeldestroyed)
            {
                puzzle.SetActive(false);
            }
            
        }
        
    }
}

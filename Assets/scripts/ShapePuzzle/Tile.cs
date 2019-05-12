using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int number;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        /*if(is1)
        {
            if (transform.position.x == pos1.x & transform.position.y == pos1.y)
            {
                set1 = true;
            }
        }

        if (is2)
        {
            if (transform.position.x == pos1.x & transform.position.y == pos1.y)
            {
                set2 = true;
            }
        }

        if(set1 & set2)
        {
            Debug.Log("yey");
        }

        if (Input.GetMouseButtonDown(0))
        {
            SelectTile();
        }
        */
    }

    /*void SelectTile()
    {
        
            }
        }
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(is1 && collision.gameObject.name == "Grid1")
        {
            
            gameObject.transform.position = pos1;
            set1 = true;
            Debug.Log("yey");
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (is1 && col.gameObject.name == "Grid1")
        {
            transform.position = pos1;
            set1 = true;
            Debug.Log("yey1");
            rb.isKinematic = true;
            rb.position = pos1;

        }
    }
    

    void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Move by Rigidbody rather than transform directly
        rb.MovePosition(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen)));
    }
    */
    /*

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (is1 && collision.gameObject.name == "Grid1")
        {
            GameObject.Find("1").GetComponent<ClickDrag>().enabled = false;
            Debug.Log("yey1");
            
        }
    }
    */

    private void OnMouseUp()
    {
        ShapePuzzleManager.Instance.lastDraggedTile = this;
        ShapePuzzleManager.Instance.CheckTileDistances();
    }

}

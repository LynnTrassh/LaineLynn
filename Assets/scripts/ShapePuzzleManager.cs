using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePuzzleManager : MonoBehaviour
{
    public static ShapePuzzleManager Instance = null;

    public bool[] settled;
    public GridNode[] gridNodes;
    public Tile[] tiles;

    public Tile lastDraggedTile;
    public float thresholdDistance;


    public AudioSource audiosource;
    public AudioClip puzzleSound;

    

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(settled[0] == true && settled[1] == true && settled[2] == true && settled[3] == true && settled[4] == true && settled[5] == true)
        {
            Debug.Log("Win!!");
        }

        
    }

    public void CheckTileDistances()
    {
        for (int i = 0; i < gridNodes.Length; i++)
        {
            float distance = Vector3.Distance(gridNodes[i].transform.position, lastDraggedTile.transform.position);
            Debug.Log("distance: " + distance);
            if (distance < thresholdDistance)
            {
                
                SnapToGridPoint(gridNodes[i]);
                break;
            }
        }
    }

    void SnapToGridPoint (GridNode gridNode)
    {
        lastDraggedTile.transform.position = gridNode.transform.position;
        audiosource.PlayOneShot(puzzleSound);
        //gridNode.tileOnNode = lastDraggedTile;
        ////for (int i =  0; i < gridNodes.Length; i++)
        /*if(gridNode.answerNumber == lastDraggedTile.number)
        {
            
            Debug.Log("score = " + score);
            Destroy(lastDraggedTile.GetComponent<ClickDrag>());
            

        }
        */

        if(gridNode.answerNumber == 1 && lastDraggedTile.number == 1)
        {
            settled[0] = true;
            

        }
        else if (gridNode.answerNumber == 2 && lastDraggedTile.number == 2)
        {
            settled[1] = true;
        }
        else if (gridNode.answerNumber == 3 && lastDraggedTile.number == 3)
        {
            settled[2] = true;
        }
        else if (gridNode.answerNumber == 4 && lastDraggedTile.number == 4)
        {
            settled[3] = true;
        }
        else if (gridNode.answerNumber == 5 && lastDraggedTile.number == 5)
        {
            settled[4] = true;
        }
        else if (gridNode.answerNumber == 6 && lastDraggedTile.number == 6)
        {
            settled[5] = true;
        }


    }
}

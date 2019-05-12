using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePuzzleChangeSprite : MonoBehaviour
{
    public bool puzzlereadytosolve;
    public bool puzzlefinished;

    
    public Sprite piecesready;
    public Sprite solved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(puzzlereadytosolve & !puzzlefinished)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = piecesready;
            this.gameObject.GetComponent<MouseOver>().ShapePuzzleReadyToSolve = true;

        }
        if (puzzlereadytosolve & puzzlefinished)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = solved;
            this.gameObject.GetComponent<MouseOver>().ShapePuzzleComplete = true;

        }
    }
}

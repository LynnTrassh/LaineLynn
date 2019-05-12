using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseChangeSprites : MonoBehaviour
{

    public SpriteRenderer sr;
    public Sprite[] vaseSprites;
    public int a;

    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        sr = GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        sr.sprite = vaseSprites[a];
    }

    public void ChangeSprite()
    {
        a = 1;
    }

    public void AddFlower()
    {
        a = 2;
    }
}

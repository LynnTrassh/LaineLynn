using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    
    private Vector3 click;
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
    }
}

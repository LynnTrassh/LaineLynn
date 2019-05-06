using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickZoom : MonoBehaviour
{

    public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Camera.transform.position = new Vector3(0, 0, (transform.position.z + 20));
    }
}

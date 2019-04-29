using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraManager : MonoBehaviour
{

    public Button rightArrow;
    public Button leftArrow;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void RightArrowClick()
    {
        if(transform.position.x >= 12)
        {
            transform.position = new Vector3(-23, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + 12, transform.position.y, transform.position.z);
        }
    }

    public void LeftArrowClick()
    {
        if (transform.position.x <= -23)
        {
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 12, transform.position.y, transform.position.z);
        }
    }
}

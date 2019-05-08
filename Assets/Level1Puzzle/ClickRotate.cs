using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRotate : MonoBehaviour
{
    public float moveSpeed;
    public bool longNeedle;
    public bool shortNeedle;
    public bool longokie;
    public bool shortokie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(longokie && shortokie)
        { Debug.Log("win"); }


        if (longNeedle)
        {
            if (transform.rotation.z == 0)
            {
                longokie = true;
            }
            else if (transform.rotation.z != 0)
            {
                longokie = false;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Rotate(Vector3.forward * moveSpeed * -1);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Rotate(Vector3.forward * moveSpeed * 1);
            }
        }

        if(shortNeedle)
        {
            if (transform.rotation.z == 180)
            {
                shortokie = true;
            }
            else if (transform.rotation.z != 180)
            {
                shortokie = false;
            }


            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * moveSpeed * -1);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.forward * moveSpeed * 1);
            }

            
        }

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnegameManager : MonoBehaviour
{

    
    public AudioSource clocksource;
    public AudioClip clock;
    

    public GameObject Long;
    public GameObject Short;
    // Start is called before the first frame update
    void Start()
    {
        clocksource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Long.transform.eulerAngles.z <29 && Long.transform.eulerAngles.z > -29)
        {
            if (Short.transform.eulerAngles.z < 200 && Short.transform.eulerAngles.z > 160)
            {
                Debug.Log("Win");
                clocksource.PlayOneShot(clock);
            }
            
        }
    }
}

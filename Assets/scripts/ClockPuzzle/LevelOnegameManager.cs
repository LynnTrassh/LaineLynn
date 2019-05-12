using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnegameManager : MonoBehaviour
{

    
    public AudioSource audiosource;
    public AudioSource Wall1audiosource;
    public AudioClip audioclip;
    

    public GameObject Long;
    public GameObject Short;
    public bool alreadyplayed;
    // Start is called before the first frame update
    void Start()
    {
        alreadyplayed = false;
        DontDestroyOnLoad(audiosource);
    }

    // Update is called once per frame
    void Update()
    {
        if (Long.transform.eulerAngles.z <29 && Long.transform.eulerAngles.z > -29)
        {
            if (Short.transform.eulerAngles.z < 200 && Short.transform.eulerAngles.z > 160)
            {
                Debug.Log("Win");
                if(!alreadyplayed)
                {
                    audiosource.PlayOneShot(audioclip);
                    Wall1audiosource.Play();
                    Wall1audiosource.loop = true;
                    alreadyplayed = true;
                    
                }
                
            }
            
        }
    }
}

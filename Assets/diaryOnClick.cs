using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaryOnClick : MonoBehaviour
{
    public GameObject Diary;
    public GameObject Wall3;
    public GameObject gamemanager;

    public bool exit;
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
        if(exit)
        {
            Diary.SetActive(false);
            Wall3.SetActive(true);
        }
        else
        {
            Diary.SetActive(true);
            Wall3.SetActive(false);
            gamemanager.GetComponent<gameManager>().diarycomplete = true;

        }
        


    }

    public void DiaryExit()
    {
        Diary.SetActive(false);
        Wall3.SetActive(true);
    }
}

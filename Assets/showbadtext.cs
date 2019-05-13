using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showbadtext : MonoBehaviour
{

    public float speed = 0.05f;
    public string[] fulltext;
    public string currenttext = "";
    public Text badendtext;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowgBadText());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ShowgBadText()
    {
        if (a == 0)
        {
            for (int i = 0; i < fulltext[0].Length; i++)
            {
                currenttext = fulltext[0].Substring(0, i);
                badendtext.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);
            }
            
            a = 1;
        }

        if (a == 1)
        {
            for (int i = 0; i < fulltext[1].Length; i++)
            {
                currenttext = fulltext[1].Substring(0, i);
                badendtext.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);
            }
            a = 2;
        }
        if (a == 2)
        {
            for (int i = 0; i < fulltext[2].Length; i++)
            {
                currenttext = fulltext[2].Substring(0, i);
                badendtext.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);
            }

            a = -1;

        }

        if(a == -1)
        {
            SceneManager.LoadScene("BadEnding");
        }





    }
}

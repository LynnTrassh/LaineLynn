using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showgoodtext : MonoBehaviour
{

    public float speed = 0.05f;
    public string[] fulltext;
    public string currenttext = "";
    public Text goodendtext;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowgGoodText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowgGoodText()
    {
        if (a == 0)
        {
            for (int i = 0; i < fulltext[0].Length; i++)
            {
                currenttext = fulltext[0].Substring(0, i);
                goodendtext.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);

                
            }
            a = 3;
        }

        if (a == 3)
        {
            for (int i = 0; i < fulltext[1].Length; i++)
            {
                currenttext = fulltext[1].Substring(0, i);
                goodendtext.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);


            }

            a = -1;
        }

        if (a == -1)
        {
            //for Laine to add the good scene.
            //SceneManager.LoadScene("GoodEnding");
        }


    }
}

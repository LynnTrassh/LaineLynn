using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public bool oktotalk = false;
    public Text Text;
    public Text goodendtext;
    public Text badendtext;
    public int a = 50;
    public float speed = 0.05f;
    public string[] fulltext;
    public string currenttext = "";
    private string emptystring;
    public bool yes = false;
    public bool no = false;
    public GameObject choices;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        if (a == 0)
        {
            StartCoroutine(ShowText());
        }
    }




    // Update is called once per frame


    IEnumerator ShowText()
    {
        if (a == 0)
        {
            for (int i = 0; i < fulltext[a].Length; i++)
            {
                currenttext = fulltext[a].Substring(0, i);
                Text.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);
            }

            a = 1;
        }
        if (a == 1)
        {
            for (int i = 0; i < fulltext[1].Length; i++)
            {
                currenttext = fulltext[1].Substring(0, i);
                Text.GetComponent<Text>().text = currenttext;

                yield return new WaitForSeconds(speed);
            }
            a = -1;
        }
        if (a == -1)
        {
            Destroy(Text);
            choices.SetActive(true);
        }



    }

    

    

}

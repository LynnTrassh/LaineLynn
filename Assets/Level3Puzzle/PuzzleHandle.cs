using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knight
{
    public class PuzzleHandle : MonoBehaviour {
        public Animator Anim;
        public bool NumberCorrect;
        int score;

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
            if(PuzzleControl.Main.NumberCorrect == true)
            {
                Debug.Log("Open");
            }
        }
       
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Knight
{
    public class PuzzleButton : MonoBehaviour {
        public int Index;
        public int Value;

      
        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                
            }
        }

        public void OnMouseDown()
        {
          
            Debug.Log("click");
            PuzzleControl.Main.ChangeNumber(Index, Value);
            

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
   [SerializeField] [Range(1, 20)] int number = 0;
   [SerializeField] float Othernumber = 0;

    [SerializeField] char letter = 'a';
    [SerializeField] string phrase = "hello class";
    bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        //Print();
       // int i = 10;
      //  float j = 2.0f;
       // Debug.Log(i + j);
    //   Mathf.Min(Othernumber, number);
    }

    // Update is called once per frame
    void Update()
    {
      //  { 
      //      Debug.Log("!!!!!");
      //  }
      //  Debug.Log(phrase);
    }

    [ContextMenu("Print Phrase")]
    void Print()
    {
   
        Debug.Log(phrase);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    [SerializeField] private Stack<string> myStack = new Stack<string>();

    // Start is called before the first frame update
    void Start()
    {
        myStack.Push("First");
        myStack.Push("Second");
        myStack.Push("Third");
        while (myStack.Count > 0)
        {
            string item = myStack.Pop();
            Debug.Log(item);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

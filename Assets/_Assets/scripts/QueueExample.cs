using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    [SerializeField] private Queue<string> myQueue = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {
        myQueue.Enqueue("First");
        myQueue.Enqueue("Second");
        myQueue.Enqueue("Third");
        while (myQueue.Count > 0)
        {
            string item = myQueue.Dequeue();
            Debug.Log(item);
        }
    }
}

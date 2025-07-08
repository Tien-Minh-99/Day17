using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    [SerializeField] private List<int> myList;
    // Start is called before the first frame update
    void Start()
    {
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Remove(12);
        foreach(int item in myList)
        {
            Debug.Log(item);
        }
        
     
    }

    
}

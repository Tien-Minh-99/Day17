using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Banana", 2);
        myDictionary.Add("Cherry", 3);
        foreach(KeyValuePair<string,int>item in myDictionary)
        {
            Debug.Log(item.Key + ":" + item.Value);
        }
        myDictionary.Clear();

        
    }
   

    
}

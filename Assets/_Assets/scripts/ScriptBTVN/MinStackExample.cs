using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinStackExample : MonoBehaviour
{
    private Stack<int> main = new Stack<int>();
    private Stack<int> mins = new Stack<int>();

    void Start()
    {
        Push(5); Push(3); Push(7);
        Debug.Log(GetMin()); // 3
        Pop();               // bỏ 7
        Debug.Log(GetMin()); // 3
        Pop();               // bỏ 3
        Debug.Log(GetMin()); // 5
    }

    void Push(int value)
    {
        main.Push(value);
        if (mins.Count == 0 || value <= mins.Peek()) mins.Push(value);
        //mỗi lần push, nếu giá trị nhỏ hơn hoặc bằng min hiện tại, cũng push vào stack phụ mins
    }

    void Pop()
    {
        if (main.Pop() == mins.Peek()) mins.Pop();
    }

    int GetMin() => mins.Peek();
}

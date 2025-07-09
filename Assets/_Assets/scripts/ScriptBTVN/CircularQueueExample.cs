using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularQueueExample : MonoBehaviour
{ // tạo vòng lặp vô hạn 
    private Queue<string> skills = new Queue<string>();

    void Start()
    {
        skills.Enqueue("Fireball");
        skills.Enqueue("Ice Blast");
        skills.Enqueue("Heal");

        InvokeRepeating(nameof(UseSkill), 1f, 1f);
    }

    void UseSkill()
    {
        string skill = skills.Dequeue();
        Debug.Log("Dùng kỹ năng: " + skill);
        skills.Enqueue(skill); // Đưa lại vào cuối => vòng lặp
    }
}
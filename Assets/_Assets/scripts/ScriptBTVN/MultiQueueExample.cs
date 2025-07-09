using System.Collections.Generic;
using UnityEngine;

public class MultiQueueExample : MonoBehaviour
{
    private Dictionary<string, Queue<string>> enemyTasks = new();// sử dụng để quản lý nhiều hàng đợi 

    void Start()
    {
        enemyTasks["Goblin"] = new Queue<string>();
        enemyTasks["Dragon"] = new Queue<string>();
        // mỗi enemy có 1 queue riêng, quản lý độc lập rõ ràng 
        enemyTasks["Goblin"].Enqueue("Rút lui");
        enemyTasks["Goblin"].Enqueue("Bắn");

        enemyTasks["Dragon"].Enqueue("Thở lửa");

        foreach (var task in enemyTasks["Goblin"])
            Debug.Log("Goblin: " + task);

        foreach (var task in enemyTasks["Dragon"])
            Debug.Log("Dragon: " + task);
    }
}

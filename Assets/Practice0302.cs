using System.Collections;
using UnityEngine;
public class Practice0302 : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count : {queue.Count}");
        Debug.Log($"현재 0번 요소 : {queue.Peek()}");
        Debug.Log($"Queue Coount : {queue.Count}");

        object data = queue.Dequeue();

        Debug.Log($"큐에서 빠져나온 데이터 : {data}");
        Debug.Log($"Queue Coount : {queue.Count}");

        queue.Clear();

        Debug.Log($"Queue Coount : {queue.Count}");
    }
}
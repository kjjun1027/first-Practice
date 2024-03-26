using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;
public class Practice0301 : MonoBehaviour
{
    private void Awake()
    {
        ArrayList arrayList = new ArrayList();

        Debug.Log(arrayList.Add(10));
        PrintArrayList(arrayList);

        arrayList.Insert(1, 100);  
        PrintArrayList(arrayList);

        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);
        PrintArrayList(arrayList);

        arrayList.Sort();
        PrintArrayList(arrayList);

        arrayList.RemoveAt(0);
        PrintArrayList(arrayList);

        arrayList.RemoveRange(0, 2);
        PrintArrayList(arrayList);

        arrayList.Clear();
        Debug.Log(arrayList.Count);
    }
    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("=================================");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
}
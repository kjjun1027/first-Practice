using UnityEngine;

public class Practice0101 : MonoBehaviour
{
    private int currentHP = 10;
    private readonly int maxHP = 100;
    private const int maxMP = 100;

    public Practice0101()
    {
        maxHP = 200;
    }
    private void Awake()
    {
        int currentMP = 50;

        currentHP = 35;

        Debug.Log(currentHP);
        Debug.Log(currentMP);
        Debug.Log(maxHP);
    }

    private void Update()
    {

    }
}
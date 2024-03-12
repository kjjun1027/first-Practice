using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public class Player : MonoBehaviour
{
    public string playerName = "Noname";
    private int currentHP = 100;
    public void TakeDamage(int damage)
    {
        currentHP = damage;
        Debug.Log(currentHP);
    }
}
public class Practice02 : MonoBehaviour
{
    private void Awake()
    {
        Player player;

        player = GameObject.Find("PlayerObject").GetComponent<Player>();

        player.playerName = "고박사"
;
        player.TakeDamage(10);
    }
}
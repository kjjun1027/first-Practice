﻿using System;
using System.Reflection;
using UnityEngine;

public class Practice0105 : MonoBehaviour
{
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        int[][] array = new int[3][];

        array[0] = new int[3] {1, 2, 3};
        array[1] = new int[] { 10, 20, 30 };
        array[2] = new int[] { 100, 200, 300,400,500 };

        for(int i = 0; i < array.Length; ++i)
        {
            for(int j = 0; j < array[i].Length; ++j)
            {
                Debug.Log($"[{i}],[{j}] = {array[i][j]}");
            }
        }
        /* 07.배열
        int[] enemys = new int[5];

        Debug.Log($"배열의 타입 : {enemys.GetType()}");
        Debug.Log($"배열의 기본 타입 : {enemys.GetType().BaseType}");

        Debug.Log("== 정렬 전 ==");
        for(int index =0; index < enemys.Length; ++index)
        {
            enemys[index] = UnityEngine.Random.Range(0, 100);
            Debug.Log(enemys[index]);
        }

        Array.Sort( enemys );

        Debug.Log("== 정렬 후 ==");
        for(int index =0;index < enemys.Length;++index)
        {
            Debug.Log(enemys[index]);
        }

        Debug.Log($"Dimensions : {enemys.Rank}");
        /*06. 반복문 while
        int result = 0;
        int index = 1;

        while(index<=100)
        {
            result += index;
            index++;
        }
        Debug.Log($"1부터 100까지의 합은 {result}");
        /*05.반복문 for
        for (int index = 0; index < 10; index++)
        {
            Debug.Log(index);
        }
        for(int x = 0; x < 10; ++x)
        {
            for(int y = 0; y < 10; ++y)
            {
                Debug.Log($"{x} x {y} = {x*y}");
            }
        }
        /*04.조건문 switch-case
        x /= 10;
        switch(x)
        {
            case 10:
                Debug.Log("학점 : A+");
                break;
            case 9:
                Debug.Log("학점 : A+");
                break;
            case 8:
                Debug.Log("학점 : B+");
                break;
            case 7:
                Debug.Log("학점 : C+");
                break;
            case 6:
                Debug.Log("학점 : D");
                break;
            default:
                Debug.Log("학점 : F");
                break;
        }
        /*02.조건문 if,else if, else
        if (x >= 90)
        {
            Debug.Log("학점 : A+");
        }
        else if (x >= 80)
        {
            Debug.Log("학점 : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("학점 : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("학점 : D");
        }
        else
        {
            Debug.Log("학점 : F");
        }
        /*01. 조건문 if
        if (x % 2 == 0)
        {
            Debug.Log("x는 짝수다");
        }
        else
        {
            Debug.Log("x는 홀수다");
        }
        if (x > 5 && x < 10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }
        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다");
            }
        }
        Debug.Log($"x의 값은 {x}");*/

    }
}
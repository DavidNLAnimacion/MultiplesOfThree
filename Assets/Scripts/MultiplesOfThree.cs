using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    void Start()
    {
        ShowMultiplesOfThree();
    }

    void ShowMultiplesOfThree()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    // Start is called before the first frame update

    int Multiplys(int a, int b)
    {
        return a * b;
    }

    void Start()
    {
        // int number = 5;
        for (int i = 1; i <= 10; i++)
        {
            int number = i;
            for (int j = 1; j <= 10; j++)
            {
                int result = Multiplys(number, j);
                Debug.Log("Multiplication table for the number  " + $"{number} x {j} = {result}");
            }
        }

    }


}

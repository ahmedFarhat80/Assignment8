using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Assignment8part2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] animals = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };

        int wordCount = 0;
        string funnySentence = "";

        while (wordCount < 7)
        {
            int indexWordRandom = Random.Range(0, animals.Length);
            funnySentence = funnySentence + animals[indexWordRandom] + " ";
            wordCount++;
        }

        Debug.Log(funnySentence);
    }

}

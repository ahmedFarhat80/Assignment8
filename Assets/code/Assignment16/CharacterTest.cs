using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{

    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {

            Character[] characters = new Character[]
            {
            new Soldier(),
            new Officer("Captain", 90, new Position(1, 2, 3))
            };

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Officer officer = (Officer)characters[1];
            Soldier soldier = (Soldier)characters[0];

            Debug.Log($"Soldier Health Before the attack: {soldier.Health}");
            officer.Attack(20, soldier, "shooting");
            Debug.Log($"Soldier Health After the attack: {soldier.Health}");

        }

    }
}
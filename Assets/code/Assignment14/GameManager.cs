using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player2 player = new Player2("Ahmed Farhat", 90);
        Enemy enemy = new Enemy("IS", 100);

        Debug.Log("Player: " + player._name + ", Health: " + player._health);
        Debug.Log("Enemy: " + enemy._name + ", Health: " + enemy._health);

        player.Heal(20);
        Debug.Log("Player after healing: " + player._name + ", Health: " + player._health);

        enemy.Attack(200);
        Debug.Log("Player after attack: " + enemy._name + ", Health: " + enemy._health);

        enemy.Attack(player, 200);
        Debug.Log("Player after attack: " + player._name + ", Health: " + player._health);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string name;
    int health;
    public static int playerCount = 0;


    public void InitializePlayer(string playerName, int initialHealth)
    {
        name = playerName;
        health = initialHealth;
        playerCount++;
    }
    public static void ShowPlayerCount()
    {
        Debug.Log("Total players: " + playerCount);
    }

    public void Heal(int addHealth)
    {
        if (health + addHealth >= 100) health = 100;
        else health += addHealth;

        Debug.Log($"{name} healed by {addHealth}. Current health: {health}");
    }


    public void Heal(bool resetHealth)
    {
        if (resetHealth == true)
        {
            health = 100;
            Debug.Log("Reset Health " + this.name);
        }
        else Debug.Log("Game Over " + this.name);
    }
}

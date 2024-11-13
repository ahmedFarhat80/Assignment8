using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Player2
{
    public Enemy(string name, int health) : base(name, health) { }

    // This class below reduces the enemy health.
    public void Attack(int damage)
    {
        _health -= damage;
    }


    // This class below reduces the Player health.
    public void Attack(Character player, int damage)
    {
        player._health -= damage;
    }


}

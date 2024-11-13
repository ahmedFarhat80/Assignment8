using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name;
    private int health;

    public string _name
    {
        get { return name; }
        set { name = value; }
    }

    public int _health
    {
        get { return health; }

        set
        {
            if (value >= 100) health = 100;
            else if (value < 0) health = 0;
            else health = value;
        }
    }

    public Character(string name, int health)
    {
        this._name = name;
        this._health = health;
    }

}

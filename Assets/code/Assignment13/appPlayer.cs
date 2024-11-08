using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player Player1 = new Player();
        Player Player2 = new Player();

        Player1.InitializePlayer("Ahmed Farhat", 20);
        Player2.InitializePlayer("Ali MFC", 100);
        Player.ShowPlayerCount();

        // Player1.Heal(false);
        // Player2.Heal(true);
        Player1.Heal(20);
        Player2.Heal(50);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;

        while (i < 8)
        {
            int randomNumper = Random.Range(1, 20);
            Debug.Log(randomNumper);
            i++;
            if (randomNumper == 5)
            {
                // Debug.Log("continue is Run");
                continue;
            }
            else if (randomNumper == 15)
            {
                break;
            }
        }

    }


}

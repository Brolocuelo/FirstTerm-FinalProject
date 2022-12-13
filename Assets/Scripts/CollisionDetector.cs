using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Coin"))
        {
            Destroy(other.gameObject);
            coins += 1;
            Debug.Log("You have earned one coin");
            if(coins >= 30)
            {
                Time.timeScale = 0;
                Debug.Log("¡You have won!");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public int playerIndex; //Indice del array de jugador

    private float yRange = 10f;

    private void Update()
    {
       SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        Vector3 pos = transform.position;

        if (pos.y < -yRange)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        /*if (pos.y > yRange)
        {
            transform.position = new Vector3(pos.x, 0, pos.z);
        }*/
    }
}

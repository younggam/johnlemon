using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameEnding gameEnding;

    bool isPlayerInRange;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.transform == player)
        {
            isPlayerInRange = false;
        }
    }

    void Update()
    {
        if (isPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new(transform.position, direction);

            if (Physics.Raycast(ray, out RaycastHit raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    gameEnding.CaughtPlayer();
                }
            }
        }
    }
}

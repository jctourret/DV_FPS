using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GhostScript : MonoBehaviour
{
    int GhostHitPoints = 10;
    void Update()
    {
        if (GhostHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void DeductPoints(int damage)
    {
        GhostHitPoints -= damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GlobalAmmo.currentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}

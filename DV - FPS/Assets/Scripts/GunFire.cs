using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            GlobalAmmo.currentLoaded -= 1;
            GetComponent<Animation>().Play("Gunshot");
        }        
    }
}

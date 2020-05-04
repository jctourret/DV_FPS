using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    static public int currentAmmo;
    public int internalAmmo;
    public GameObject ammoDisplay;
    void Update()
    {
        internalAmmo = currentAmmo;
        ammoDisplay.GetComponent<Text>().text = "" + internalAmmo;
    }
}

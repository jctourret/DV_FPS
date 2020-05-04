using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    static public int currentAmmo;
    public int internalAmmo;
    public GameObject ammoDisplay;

    static public int currentLoaded;
    public int internalLoaded;
    public GameObject loadedDisplay;
 
    void Update()
    {
        internalAmmo = currentAmmo;
        internalLoaded = currentLoaded;
        ammoDisplay.GetComponent<Text>().text = "" + internalAmmo;
        loadedDisplay.GetComponent<Text>().text = "" + internalLoaded;
    }
}

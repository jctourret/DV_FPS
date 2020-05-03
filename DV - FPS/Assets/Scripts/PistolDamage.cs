using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PistolDamage : MonoBehaviour
{
    [SerializeField] int damage = 5;
    [SerializeField] float targetDistance;
    [SerializeField] float AllowedRange = 5;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 100, Color.yellow);
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit shot;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
            {
                targetDistance = shot.distance;
                if (targetDistance < AllowedRange)
                {
                    shot.transform.SendMessage("DeductPoints", damage);
                }

            }
        }        
    }
}

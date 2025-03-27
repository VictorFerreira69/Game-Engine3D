using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    Transform raycastOrigin;
   
    void Start()
    {
        raycastOrigin = Camera.main.transform;  
    }
    private void Update()
    {
        Debug.DrawRay(raycastOrigin.position, raycastOrigin.forward * 10, Color.black);
    }


    void FixedUpdate()
    {
        if (Physics.Raycast(raycastOrigin.position, raycastOrigin.forward,out RaycastHit hit))
        {
            print("hit.collider");
        }
    }
}

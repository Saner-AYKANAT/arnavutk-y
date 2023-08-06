using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAycast : MonoBehaviour
{
    public float raycastDistance = 10f;

    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

       
        RaycastHit hit;

      
        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            
            Debug.Log("Raycast hit object: " + hit.collider.gameObject.name);

           
            hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}

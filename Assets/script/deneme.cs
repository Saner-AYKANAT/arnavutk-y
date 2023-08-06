using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
   
    

       
    public float moveSpeed = 5.0f;

    void Update()
    {
        
        float verticalInput = Input.GetAxis("Vertical");

      
        Vector3 movement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;

       
        transform.position += movement;
    }
}






    


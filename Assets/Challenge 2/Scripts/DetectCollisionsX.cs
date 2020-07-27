using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private float timeDelay;

    private void OnTriggerEnter(Collider other)
    {
       
            Destroy(other.gameObject);
            Destroy(gameObject);
        
    }

}

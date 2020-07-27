using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField]
    private float timeDelay = 0;

    // Update is called once per frame
    void Update()
    {
        timeDelay++;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeDelay >= 150)
        {
            timeDelay = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}

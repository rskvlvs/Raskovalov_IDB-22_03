using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Object is activaded");
            sphere.SetActive(true);
        }
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log("Object is deactivated");
            sphere.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere; 
    public void ButtonPressed()
    {
        if (sphere.active == false)
        {
            Debug.Log("Object is deactivated");
        }
        if (sphere.active == true)
        {
            Debug.Log("Object is activated"); 
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

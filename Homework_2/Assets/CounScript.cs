using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class CounScript : MonoBehaviour
{
    public Text Count;
    public CollisionScript Cube; 
    void Start()
    {
 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Count.text = "Count = " + Cube.counter; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionScript : MonoBehaviour
{

    public int counter; 
    public void OnCollisionEnter()
    {
        counter = 100; 
        Debug.Log("It's working!");
        counter = counter - 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

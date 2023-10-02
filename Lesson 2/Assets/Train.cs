using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public int Q; //Для подсчета
    public GameObject T;
    private int E = 5;
    private int C;
    public int B = 0;
    // Start is called before the first frame update
    void Start()
    {
        C = Q + E;
        Debug.Log("Сумма Q и E = " + C);
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        B++;
        Debug.Log(B);
        if (B >= 50)
        {
            T.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        { 
            T.SetActive(false); 
            this.gameObject.SetActive(true);    
        }
    }
}

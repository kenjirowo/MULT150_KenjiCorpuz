using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int evens = 22;
        
        Debug.Log(evens);

        while (evens < 100)
        {
            evens += 2;
            Debug.Log(evens);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 1 ; x <= 31; x++)
        {
            if (x == 6)
            {
                Debug.Log("It's My Birthday!");
            }
            else
            {
              Debug.Log(x);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;
    void Start()
    {
        target = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        target.transform.Translate(mxVal, myVal, 0);
    }
}

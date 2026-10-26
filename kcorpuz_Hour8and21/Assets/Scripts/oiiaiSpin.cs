using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oiiaiSpin : MonoBehaviour
{
    private GameObject target;
    private bool isSpinning = false;
    private float rotationAmount= 0f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("3D Audio");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !isSpinning)
        {
            isSpinning = true;
            rotationAmount =0f;                
        }
        
        if (isSpinning)
        {
            float rotation = 180f * Time.deltaTime;

            target.transform.Rotate(0f, rotation, 0f);
            rotationAmount += rotation;

            if (rotationAmount >= 360f)
            {
                isSpinning = false;
            }
        }
    }
}

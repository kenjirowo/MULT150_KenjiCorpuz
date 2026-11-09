using UnityEngine;
public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    int ballCounter = 0;
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            Destroy (collidedWith);
            ballCounter += 1;
        }

        if (ballCounter == 5)
        {
            GetComponent<Light>().enabled = false;
        }
    }
}
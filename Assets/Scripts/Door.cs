using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool open = false;
    private float distanceLeft = 0f;
    [SerializeField]
    private float doorSpeed = 5f;

    public void openSesame()
    {
        if(Mathf.Abs(distanceLeft) > 0.1) 
            return;
        else 
        {
            distanceLeft = open ? 5f : -5f;
            open = !open;
        }
    }

    void Update() 
    {
        if(Mathf.Abs(distanceLeft) > 0.1) {
            float aux = distanceLeft;
            distanceLeft = Mathf.Lerp(distanceLeft, 0, doorSpeed * Time.deltaTime);
            
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (aux - distanceLeft));

        }
        print(distanceLeft);
    }
}

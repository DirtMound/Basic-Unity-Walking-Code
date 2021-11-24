using UnityEngine;

public class Player : MonoBehaiviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            transform.position += Vector3.right;

        if (Input.GetKeyDown(KeyCode.A))
            transform.position += Vector3.left;

        if (Input.GetKeyDown(KeyCode.W))
            transform.position += Vector3.forward;

        if (Input.GetKeyDown(KeyCode.S))
            transform.position += Vector3.back;
        
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(0, 0.5f, 0);
    }
}
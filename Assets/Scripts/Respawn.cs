using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        //Quaternion rotate = Quaternion.Euler(0f, 0f, 0f);
        Quaternion rotate = Quaternion.Euler(0f, 180f, 0f);

        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(0f, 1.65f, 0f);
            transform.rotation = rotate;

        }
    }
}

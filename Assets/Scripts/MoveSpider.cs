using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpider : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && speed != 0)
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S) && speed != 0)
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A) && speed != 0)
        {
            transform.Rotate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && speed != 0)
        {
            transform.Rotate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        }
    }
}

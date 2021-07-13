using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Helper")
        {
            if (GetComponent<MeshRenderer>().material.color != new Color32(255, 0, 70, 1))
            {
                GetComponent<MeshRenderer>().material.color = new Color32(255, 0, 70, 1);
                SumScore.Add(1);
            }
        }
    }
}

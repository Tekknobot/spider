using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLook : MonoBehaviour
{
    public GameObject spider;
    public Camera cam;

    public LineRenderer aimTarget;
    public GameObject firePoint;
    public GameObject lookAt;

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("NPC");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(FindClosestEnemy().transform.position, spider.transform.position) < 1000)
        {
            RaycastHit hit;
            if (Physics.Raycast(firePoint.transform.position, Vector3.forward, out hit, 2000f))
            {
                if (hit.transform.tag != "NPC")
                {
                    aimTarget.SetPosition(0, firePoint.transform.position);
                    aimTarget.SetPosition(1, FindClosestEnemy().transform.position);
                    transform.LookAt(FindClosestEnemy().transform);
                }
            }
        }
        else
        {
            transform.LookAt(lookAt.transform);
        }
    }
}

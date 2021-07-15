using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLook : MonoBehaviour
{
    public GameObject spider;
    public Camera cam;

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
        if (Vector3.Distance(FindClosestEnemy().transform.position, transform.position) < 1000)
        {
            transform.LookAt(FindClosestEnemy().transform);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.forward, out hit, 2000))
            {
                if (hit.transform.tag == "NPC")
                {
                    spider.transform.LookAt(FindClosestEnemy().transform);
                    spider.GetComponent<MoveSpider>().speed = 0;
                }
            }

            if (hit.transform.tag == "Terrain")
            {
                spider.GetComponent<MoveSpider>().speed = 250;
                transform.position = transform.position;
            }
        }
    }
}

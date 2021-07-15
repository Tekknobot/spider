using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderLaser : MonoBehaviour
{
    public GameObject laser;
    public GameObject firePoint;

    private GameObject laserInstance;
    private Hovl_Laser LaserScript;
    private Hovl_Laser2 LaserScript2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            laserInstance = Instantiate(laser, firePoint.transform.position, firePoint.transform.rotation);
            laserInstance.transform.parent = transform;
            LaserScript = laserInstance.GetComponent<Hovl_Laser>();
            LaserScript2 = laserInstance.GetComponent<Hovl_Laser2>();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (LaserScript) LaserScript.DisablePrepare();
            if (LaserScript2) LaserScript2.DisablePrepare();
            Destroy(laserInstance, 0.5f);
        }
    }
}

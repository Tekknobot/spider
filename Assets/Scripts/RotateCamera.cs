using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour
{

    public float rotationAmount;
    public float rotationSpeed;
    public Vector3 destEuler = new Vector3(45, 45, 0);
    private Vector3 currEuler = new Vector3(45, -45, 0);

    // Use this for initialization
    void Start()
    {
        transform.eulerAngles = destEuler;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            destEuler.y += rotationAmount;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            destEuler.y -= rotationAmount;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            destEuler.x += rotationAmount;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            destEuler.x -= rotationAmount;
        }

        currEuler = Vector3.Lerp(currEuler, destEuler, Time.deltaTime * rotationSpeed);
        transform.eulerAngles = currEuler;


    }
}
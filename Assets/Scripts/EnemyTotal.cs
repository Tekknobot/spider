using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTotal : MonoBehaviour
{
    public GameObject spider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = spider.GetComponent<ScoreTrigger>().enemies.Length.ToString();
    }
}

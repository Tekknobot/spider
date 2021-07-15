using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTrigger : MonoBehaviour
{
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("NPC");
    }

    // Update is called once per frame
    void Update()
    {
        if (SumScore.Score == enemies.Length)
        {
            Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, 100, 100 * Time.deltaTime);
        }

        if (Camera.main.orthographicSize == 100)
        {
            SceneManager.LoadScene(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittedObject : MonoBehaviour
{

    public float startHealth = 100;
    public float health;
    public SkinnedMeshRenderer rend;

    // Use this for initialization
    void Start()
    {
        health = startHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        StartCoroutine(BlackMat());
        if (health <= 0)
        {
            Destroy(gameObject);
            SumScore.Add(1);
        }
    }

    IEnumerator BlackMat()
    {
        rend.material.color = new Color32(255, 255, 255, 1);
        yield return new WaitForSeconds(0.1f);
        rend.material.color = new Color32(0, 0, 0, 1);
    }
}

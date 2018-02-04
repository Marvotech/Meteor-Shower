using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

    public GameObject[] meteor;
    public float maxPos = 3.2f;
    public float delayTimer = 0.5f;
    float timer;
    

    private void Start()
    {

        timer = delayTimer;
        gameObject.transform.Rotate(0, 0, 90);
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {

            Vector3 meteorPos = new Vector3(Random.Range(-3.2f, 3.2f), transform.position.y, transform.position.z);
            Instantiate(meteor[0],meteorPos, transform.rotation);

            timer = delayTimer;

            gameObject.transform.Rotate(0, 0, 90);
        }
    
    }
}

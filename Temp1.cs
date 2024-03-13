using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp1 : MonoBehaviour
{
    int health = 5;
    int level = 1;
    float speed = 0.5f;
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}

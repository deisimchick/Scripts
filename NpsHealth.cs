using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpsHealth : MonoBehaviour
{       int health;
        int level;
        int speed;
       
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        level = 3;
        speed = 2;
        //здоровье прибавляется
        health = health + level;
        print("health"+health);

    }
    Vector3 newPosition;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }   
    
}

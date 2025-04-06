using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public float speed = 1.2f;

    public int health = 5;

    public int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        health += level; // Значение жизней соответствует значению уровня.

        print(health); // Вывод значение жизней в консоль. 

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z +=

        speed * Time.deltaTime;

        transform.position = newPosition;

    }
}

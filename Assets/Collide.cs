using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collide : MonoBehaviour
{
    private static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground" || collision.gameObject.name == "Bird1" || collision.gameObject.name == "Bird2")
        {
            counter++;
            Destroy(gameObject);
            if (counter == 10) Application.Quit();
        }
        if (collision.gameObject.name == "Person" || collision.gameObject.name == "Head")
        {
            Score.value += 10;
            counter = 0;
            Destroy(gameObject);
        }

    }
}

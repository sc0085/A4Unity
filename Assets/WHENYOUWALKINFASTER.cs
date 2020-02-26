using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WHENYOUWALKINFASTER : MonoBehaviour
{
    private float width = Screen.width;
    private float increment;
    private float timer;
    private float forward = 1;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        increment = width / 50;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + (increment * forward), transform.position.y, transform.position.z), Time.deltaTime*2);
        Vector3 test = camera.WorldToScreenPoint(transform.position);
        if (test.x >= width || test.x <= 0) forward = forward * -1;
    }
}

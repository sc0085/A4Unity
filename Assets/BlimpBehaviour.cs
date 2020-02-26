using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpBehaviour : MonoBehaviour
{
    public Rigidbody Stuff;
    public Camera cam;
    private Vector3 mouse;
    // Start is called before the first frame update
    void Start()
    {
        mouse = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.Translate(new Vector3(Input.GetAxis("Mouse X"), 0, 0));
        InvokeRepeating("Spawn", 1.0f, 1.0f);
    }

    void Spawn()
    {
        Rigidbody center = Instantiate(Stuff, new Vector3(transform.position.x, transform.position.y - .5f, -10), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        mouse = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.Translate(new Vector3(Input.GetAxis("Mouse X"), 0, 0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingflap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("goUp1", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void goUp1()
    {
        transform.eulerAngles = new Vector3(2.0f, 0, 0);
        Invoke("goUp2", 0.15f);
    }

    void goUp2()
    {
        transform.eulerAngles = new Vector3(4.0f, 0, 0);
        Invoke("goUp3", 0.15f);
    }

    void goUp3()
    {
        transform.eulerAngles = new Vector3(6.0f, 0, 0);
        Invoke("goUp4", 0.15f);
    }

    void goUp4()
    {
        transform.eulerAngles = new Vector3(8.0f, 0, 0);
        Invoke("goUp5", 0.15f);
    }

    void goUp5()
    {
        transform.eulerAngles = new Vector3(10.0f, 0, 0);
        Invoke("goDown1", 0.15f);
    }

    void goDown1()
    {
        transform.eulerAngles = new Vector3(8, 0, 0);
        Invoke("goDown2", 0.15f);
    }

    void goDown2()
    {
        transform.eulerAngles = new Vector3(6, 0, 0);
        Invoke("goDown3", 0.15f);
    }

    void goDown3()
    {
        transform.eulerAngles = new Vector3(4, 0, 0);
        Invoke("goDown4", 0.15f);
    }

    void goDown4()
    {
        transform.eulerAngles = new Vector3(2, 0, 0);
        Invoke("goDown5", 0.15f);
    }

    void goDown5()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
        Invoke("goUp1", 0.15f);
    }
}

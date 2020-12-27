using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public Joystick joystick;
    Rigidbody SphereRG;
    float speed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        SphereRG = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(joystick.Horizontal * speed, 0f, joystick.Vertical * speed);
        SphereRG.AddForce(force);
    }
}

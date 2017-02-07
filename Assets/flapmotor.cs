using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flapmotor : MonoBehaviour {
    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;

    void Start ()
    {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[1].motor;
    }

	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = -1000;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 1000;
        }
        else
        {
            jointMotor.motorSpeed = 0;
        }
        hingeJoints[1].motor = jointMotor;
    }
}

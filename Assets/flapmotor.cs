using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flapmotor : MonoBehaviour {
    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;
    Vector2 position;
    Vector3 rotation;
    public GameObject lflap;


    void Start ()
    {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
        if (lflap == null)
            lflap = GameObject.FindWithTag("lflap");
        position = lflap.transform.position;
        rotation = lflap.transform.rotation.eulerAngles;
    }

	void Update ()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    jointMotor.motorSpeed = -1000;
        //    hingeJoints[0].motor = jointMotor;
        //}
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = -1000;
            hingeJoints[0].motor = jointMotor;
        }
        else
        {
            jointMotor.motorSpeed = 0;
            hingeJoints[0].motor = jointMotor;
            Debug.Log("Reset left paddle to standard");
            lflap.transform.position = position;
            rotation.z = -15.876f;
            lflap.transform.rotation = Quaternion.Euler(rotation);
        }
    }
}

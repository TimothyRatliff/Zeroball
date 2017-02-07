using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rflapmotor : MonoBehaviour {
    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;
    Vector2 position;
    Vector3 rotation;
    public GameObject rflap;


    void Start()
    {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
        if (rflap == null)
            rflap = GameObject.FindWithTag("rflap");
        position = rflap.transform.position;
        rotation = rflap.transform.rotation.eulerAngles;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = 1000;
            hingeJoints[0].motor = jointMotor;
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    jointMotor.motorSpeed = -1000;
        //    hingeJoints[0].motor = jointMotor;
        //}
        else
        {
            jointMotor.motorSpeed = 0;
            hingeJoints[0].motor = jointMotor;
            Debug.Log("Reset right paddle to standard");
            rflap.transform.position = position;
            rotation.z = -152.411f;
            rflap.transform.rotation = Quaternion.Euler(rotation);
        }
    }
}

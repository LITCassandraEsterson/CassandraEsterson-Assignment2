using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public zoneScript zoneDetector;

    public HingeJoint2D pivotHingeJoint;
    private HingeJoint2D spinningHingeJoint;


    void Update()
    {
        CheckForKeyboardInputs();
    }

    private void CheckForKeyboardInputs()
    {
        if (zoneDetector.zoneEntered)
        {
            JointMotor2D theMotor = pivotHingeJoint.motor;
            theMotor.motorSpeed = 100f;
            pivotHingeJoint.motor = theMotor;
        }
    }
}


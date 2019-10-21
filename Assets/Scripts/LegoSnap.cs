using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoSnap : MonoBehaviour
{
    [SerializeField] float BreakForce = 1000f;
    Vector3 maleLocation;
    HingeJoint hJoint;
    bool inSnapping = false;

    public void SanppingMethod(Vector3 SnapLocation, Rigidbody cRigidBody)
    {
        inSnapping = true;
        maleLocation = SnapLocation;
        transform.position = maleLocation;
        HingeJointGeneration(cRigidBody);
    }

    private void HingeJointGeneration(Rigidbody cRigidBody)
    {
        gameObject.AddComponent<HingeJoint>();
        hJoint = GetComponent<HingeJoint>();
        hJoint.connectedBody = cRigidBody;
        hJoint.axis = new Vector3(0, 0, 1);
        hJoint.anchor = new Vector3(0, 0, 0);
        hJoint.breakForce = BreakForce;
    }
}

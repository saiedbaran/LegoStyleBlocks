using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoSnapTwoPoint : MonoBehaviour
{
    [SerializeField] float BreakForce = 1000f;
    Vector3 maleLocation;
    FixedJoint fJoint;
    bool inSnapping = false;

    public void SanppingMethod(Vector3 SnapLocation, Rigidbody cRigidBody)
    {
        inSnapping = true;
        maleLocation = SnapLocation;
        transform.position = maleLocation;
        if (gameObject.GetComponent<FixedJoint>() == null)
        {
            FixedJointGeneration(cRigidBody);
        }
        if (gameObject.GetComponent<FixedJoint>() != null)
        {
            if (gameObject.GetComponent<FixedJoint>().connectedBody != cRigidBody)
            {
                FixedJointGeneration(cRigidBody);
            }
        }

        // gameObject.AddComponent<FixedJoint>();
        // fJoint = GetComponent<FixedJoint>();
        // fJoint.connectedBody = cRigidBody;
        // fJoint.axis = new Vector3(0,0,1);
        // fJoint.anchor = new Vector3(0,0,0);
    }

    private void FixedJointGeneration(Rigidbody cRigidBody)
    {
        gameObject.AddComponent<FixedJoint>();
        fJoint = GetComponent<FixedJoint>();
        fJoint.connectedBody = cRigidBody;
        fJoint.breakForce = BreakForce;
    }
}

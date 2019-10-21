using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetectionOnePoint : MonoBehaviour
{
    //[SerializeField] GameObject TestObject;

    private void OnTriggerEnter(Collider collider) 
    {      
        if (collider.tag == "LegoMale")
        {
            Debug.Log("Lego Enters");
            collider.GetComponent<Collider>().isTrigger = true;
            //Vector3 maleLocation = collider.GetComponentInParent<MaleLocation>().GetLocation();

            Vector3 TopPosition = new Vector3(collider.transform.up.x * collider.GetComponent<Collider>().bounds.size.x /2f,collider.transform.up.y * collider.GetComponent<Collider>().bounds.size.y /2f, collider.transform.up.z * collider.GetComponent<Collider>().bounds.size.z /2f);

            Vector3 maleLocation = collider.transform.position + TopPosition;
            gameObject.GetComponentInParent<LegoSnap>().SanppingMethod(maleLocation, collider.gameObject.GetComponentInParent<Rigidbody>());
        }
    }

    private void OnTriggerStay(Collider collider) 
    {
        if (collider.tag == "LegoMale")
        {
            Debug.Log("Lego Stays");
            //Vector3 maleLocation = collider.GetComponentInParent<MaleLocation>().GetLocation();
            //gameObject.GetComponentInParent<LegoSnap>().SanppingMethod(maleLocation, collider.gameObject.GetComponent<Rigidbody>());
        }
        
    }
}

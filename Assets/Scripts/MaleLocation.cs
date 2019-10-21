using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleLocation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 GetLocation()
    {
        return transform.position;
    }
}

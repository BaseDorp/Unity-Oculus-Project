using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusFireTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("button");
        }
    }
}

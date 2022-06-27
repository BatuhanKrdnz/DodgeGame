using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rb;
    [SerializeField] float waitTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > waitTime)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;        
        }
    }
}

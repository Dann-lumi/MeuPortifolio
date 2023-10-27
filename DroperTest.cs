using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DroperTest : MonoBehaviour
{
    Rigidbody rigidbody;
    MeshRenderer renderer;
    [SerializeField] float dropTime = 0;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        } 
    }
}

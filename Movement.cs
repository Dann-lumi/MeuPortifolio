using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] float boostForce = 10;
    [SerializeField] float rotateForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        BoostingInput();
        RotatingInput();
    }
    void BoostingInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Boosting");
            body.AddRelativeForce(Vector3.up * boostForce * Time.deltaTime);
        }
    }

    void RotatingInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Rotation(rotateForce);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Rotation(-rotateForce);
        }
    }

    private void Rotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime); 
    }
}

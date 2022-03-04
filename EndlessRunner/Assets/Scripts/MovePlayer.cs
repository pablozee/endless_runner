using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float runSpeed;
    [SerializeField] private float sidewaysSpeed;
    [SerializeField] private float zMin;
    [SerializeField] private float zMax;

    private float movementValue;

    void Start()
    {
        
    }

    void Update()
    {
         transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
         transform.Translate(Vector3.right * Time.deltaTime * movementValue * sidewaysSpeed);

        if (transform.position.z < zMin)
        {
            Vector3 temporaryPosition = transform.position;
            temporaryPosition.z = zMin;
            transform.position = temporaryPosition;
        }

        if (transform.position.z > zMax)
        {
            Vector3 temporaryPosition = transform.position;
            temporaryPosition.z = zMax;
            transform.position = temporaryPosition;
        }
    }

    void OnMove(InputValue value)
    {
        movementValue = value.Get<float>();
        Debug.Log(movementValue);
    }

    public float GetRunSpeed()
    {
        return runSpeed;
    }

    public void SetRunSpeed(float newValue)
    {
        runSpeed = newValue;
    }
}

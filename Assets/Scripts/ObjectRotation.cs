using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] private GameObject cubeObject;
    [SerializeField] private GameObject sphereObject;
    [SerializeField] private GameObject capsuleObject;

    private float _rotationSpeed = 50f;

    private void Update()
    {
        cubeObject.transform.Rotate(Vector3.left, _rotationSpeed * Time.deltaTime);
        sphereObject.transform.Rotate(Vector3.left, _rotationSpeed * Time.deltaTime);
        capsuleObject.transform.Rotate(Vector3.forward, _rotationSpeed * Time.deltaTime);
    }
}

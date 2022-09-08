using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField] [Range(0,3)] private float lerpValue;


    private Vector3 offset;
    private Vector3 newPosition;


    private void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    private void LateUpdate()
    {
        CameraFollow();
    }

    private void CameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
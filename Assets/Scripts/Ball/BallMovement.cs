using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private BallController ballController;
    [SerializeField] private float ballMoveSpeed;

    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += ballController.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}

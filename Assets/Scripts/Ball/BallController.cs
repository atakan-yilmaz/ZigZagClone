using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;


    public Vector3 GetBallDirection()
    {
        return ballInputController.ballDirection;
    }
}
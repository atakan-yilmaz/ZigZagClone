using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCodeTransmitter : MonoBehaviour
{
    [SerializeField] private GroundController groundController;


    public void RBGroundValues()
    {
        StartCoroutine(groundController.RBGroundValues());
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    //fall controller

    private Rigidbody rB;

    private void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    //zeminin belli bi sureyle dusmesi icin 

    public IEnumerator RBGroundValues()
    {
        yield return new WaitForSeconds(0.75f);

        //zemini donguye sokmak icin (spawnlanmasi icin)
        rB.useGravity = true;
        rB.isKinematic = false;
    }
}
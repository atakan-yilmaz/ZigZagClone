using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;

    public GameObject lastGroundObj;
    private GameObject newGroundObj;
    private int groundDirection;

    public GameObject Score;
    private Transform scoreValue;

    private void Start()
    {
        CreateNewGround();
    }

    private void Update()
    {
        //ScoreSystem();
    }

    public void CreateNewGround()
    {
        for (int i = 0; i < 75; i++)
        {
            RandomNewGround();
        }
    }

    private void RandomNewGround()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            newGroundObj = Instantiate(groundPrefab, new Vector3(lastGroundObj.transform.position.x - 1f, lastGroundObj.transform.position.y,lastGroundObj.transform.position.z), Quaternion.identity);
            lastGroundObj = newGroundObj;
        }
        else
        {
            newGroundObj = Instantiate(groundPrefab, new Vector3(lastGroundObj.transform.position.x, lastGroundObj.transform.position.y, lastGroundObj.transform.position.z + 1f), Quaternion.identity);
            lastGroundObj = newGroundObj;
        }
    }

    //private void ScoreSystem()
    //{
    //    int ScoreValue = Random.Range(0, 11);

    //    if (ScoreValue == 1)
    //    {
    //        scoreValue = Instantiate(lastGroundObj, new Vector3(lastGroundObj.transform.position.z, lastGroundObj.transform.position.y, lastGroundObj.transform.position.z), Quaternion.identity);
    //        lastGroundObj = newGroundObj;
    //    }

    //    groundPrefab.transform.GetChild(0).gameObject.SetActive(true);
    //}


}
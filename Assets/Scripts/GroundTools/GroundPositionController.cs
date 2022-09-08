using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawner groundSpawner;
    private Rigidbody rB;



    [SerializeField] private float YStats;
    private int groundDirection;

    private void Start()
    {
        groundSpawner = FindObjectOfType<GroundSpawner>();
        rB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        VerticalPosition();
    }

    private void VerticalPosition()
    {
        //pozisyon uygun yerde olmazsa eger destroy edip vertical pozisyonunda spawn edecek
        if (transform.position.y <= YStats)
        {
            RigidbodyValues();
            NewPosition();
        }
    }

    private void NewPosition()
    {
        //random olarak ground atamasi icin 
        groundDirection = Random.Range(0, 2);

        //saga sola gitmesini kontrol etmek amaciyla 
        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawner.lastGroundObj.transform.position.x - 1f, groundSpawner.lastGroundObj.transform.position.y, groundSpawner.lastGroundObj.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundSpawner.lastGroundObj.transform.position.x, groundSpawner.lastGroundObj.transform.position.y, groundSpawner.lastGroundObj.transform.position.z + 1f);
        }

        //dusen ground parcalari tekrar arka planda bir bit kaybina neden olmadan spawnlanmasi icin
        groundSpawner.lastGroundObj = gameObject;
    }

    private void RigidbodyValues()
    {
        //donguyu sonlandirip zeminin eski haline donusmesini saglamak icin
        rB.isKinematic = true;
        rB.useGravity = false;
    }
}

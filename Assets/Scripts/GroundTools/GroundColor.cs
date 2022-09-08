using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColor : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;
    [SerializeField] private float lerpValue;

    [SerializeField] private Color[] colors;
    private int colorIndex = 0;

    [SerializeField] private float time;
    private float currentTime;


    private void Update()
    {
        GroundColorChangeTime();
        GroundMaterialColorChange();
    }

    private void GroundColorChangeTime()
    {
        if (currentTime <= 0)
        {
            currentTime = time;
            CheckColorIndex();
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndex()
    {
        colorIndex++;

        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void GroundMaterialColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    //oyunu kaybedip restart attiginda zeminin ilk bastaki rengine donusmesi icin.
    private void OnDestroy()
    {
        groundMaterial.color = colors[0];
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBoundry : MonoBehaviour
{
    public static float leftSide=-3.5f;
    public static float rightSide=3.5f;
    public  float internalLeft;
    public float internalRight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}

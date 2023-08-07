using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBirdLine : MonoBehaviour
{
    public Transform bird;
    public LineRenderer line;

    private void Start()
    {
        line.positionCount = 2;
        line.SetPosition(0, bird.position);
        line.SetPosition(1, bird.position);
    }

    public void SetPosition(int v, Vector3 position)
    {
        line.SetPosition(v, position);
    }
}

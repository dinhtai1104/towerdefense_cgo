using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AngryBirdCameraMoveType
{
    Begin,
    Moving,
}

public class AngryBirdCamera : MonoBehaviour
{
    public static AngryBirdCamera Instance;
    private void Awake()
    {
        Instance = this;
    }
    // Cần 2 trạng thái
    /*
     -Trạng thái đầu tiên: Vị trí bắt đầu game => vị trí của vị trí bắn
    - Trạng thái thứ 2: Trạng thái camera di chueyenr theo nhân vật
     
     */

    public float speed;
    public AngryBirdCameraMoveType moveType = AngryBirdCameraMoveType.Begin;
    public Transform startPoint;
    public Transform characterTransform;

    // Update is called once per frame
    void Update()
    {
        switch (moveType)
        {
            case AngryBirdCameraMoveType.Begin:
                MoveToPoint(startPoint.position);
                break;
            case AngryBirdCameraMoveType.Moving:
                MoveToPoint(characterTransform.position);
                break;
        }
    }

    public void ChangeState(AngryBirdCameraMoveType state)
    {
        moveType = state;
    }

    private void MoveToPoint(Vector3 position)
    {
        // CAMera.z = -10
        Vector3 startPoint = transform.position;
        Vector3 nextPoint = position;

        Vector3 currentStepPoint = Vector3.MoveTowards(startPoint, nextPoint, speed * Time.deltaTime);
        currentStepPoint.z = -10;
        transform.position = currentStepPoint;
    }
}

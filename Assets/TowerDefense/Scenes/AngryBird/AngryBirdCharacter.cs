using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class AngryBirdCharacter : MonoBehaviour
//{
//    public AngryBirdLine line;

//    private Vector3 startPoint;

//    private void Start()
//    {
//        startPoint = transform.position;
//    }

//    private void OnMouseUp()
//    {
//        Vector3 direction = transform.position - startPoint;
//        direction *= -1;

//        GetComponent<Rigidbody2D>().gravityScale = 1;
//        GetComponent<Rigidbody2D>().velocity = direction * 2;
//    }

//    private void OnMouseDrag()
//    {
//        Debug.Log("Mouse Drag");

//        Vector3 mousePosition = Input.mousePosition;
//        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);
//        targetPosition.z = 0;

//        transform.position = targetPosition;

//        Vector3 position = transform.position;
//        line.SetPosition(1, position);
//    }

//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        //AngryBirdCamera.Instance.ChangeState(AngryBirdCameraMoveType.Begin);
//    }
//}

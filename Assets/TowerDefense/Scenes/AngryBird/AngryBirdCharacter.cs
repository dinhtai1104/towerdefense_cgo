using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBirdCharacter : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(10, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AngryBirdCamera.Instance.ChangeState(AngryBirdCameraMoveType.Begin);
    }
}

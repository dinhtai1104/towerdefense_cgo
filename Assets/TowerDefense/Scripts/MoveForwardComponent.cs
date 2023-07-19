using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardComponent : MonoBehaviour
{
    public float speed;
    public float timeDestroy;

    private float timeDestroyCurrent = 0;

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    private void Update()
    {
        timeDestroyCurrent += Time.deltaTime;
        if (timeDestroyCurrent >= timeDestroy)
        {
            Destroy(gameObject);
            return;
        }
        transform.position += transform.right * speed * Time.deltaTime;
    }
}

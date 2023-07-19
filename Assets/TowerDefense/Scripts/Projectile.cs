using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Dmg;
    public MoveForwardComponent MoveForward;

    public void SetSpeed(float speed)
    {
        this.MoveForward.SetSpeed(speed);
    }
    public void SetDamage(float dmg)
    {
        this.Dmg = dmg;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // phat hien va cham voi quai vat
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(this.Dmg);
                Destroy(gameObject);
            }
        }
    }
}

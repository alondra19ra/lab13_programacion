using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float explosionDuration = 0.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);

            Destroy(explosionInstance, explosionDuration);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}



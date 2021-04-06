using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D body;
    private Transform myTransform;
    private Vector2 direction;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();

        GenerateRandomDirection();
    }

    private void FixedUpdate()
    {
        body.AddForce(direction);
    }

    private void GenerateRandomDirection()
    {
        Vector2 aaa = new Vector2();
        aaa.Set(Random.Range(0, 10), Random.Range(0, 10));

        direction = aaa - (Vector2)myTransform.position;
    }
}

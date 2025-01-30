using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using static UnityEngine.GraphicsBuffer;

public class Jump : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private Rigidbody2D rb;
    private float initialVelocity;
    private float g;
    private float height;

    //v0 = sqrt 2 * g * h

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    [Button("Jump to Target")]

    public void JumpMario()
    {
        g = Mathf.Abs(Physics2D.gravity.y); 
        height = targetObject.position.y - transform.position.y;

        if (height > 0)
        {
            initialVelocity = Mathf.Sqrt(2 * g * height);

            rb.velocity = new Vector2(rb.velocity.x, initialVelocity); 

        }
    }

}

using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDuration : MonoBehaviour
{
    [SerializeField] private Transform ground;
    [SerializeField] private Rigidbody2D rb;
    private float predictedTime;
    private float actualFallTime;
    private float g;
    private float height;
    private float fallTimer;
    public bool onGround = false;
    public bool isFalling = false;

    //t = sqrt 2*h/g

    void Start()
    {
        rb.isKinematic = true;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        fallTimer = 0f;
    }

    [Button("Calculate Prediction")]
    public void PredictFall()
    {
        height = transform.position.y - ground.position.y;
        g = Mathf.Abs(Physics2D.gravity.y);
        predictedTime = Mathf.Sqrt((2 * height) / g);
        Debug.Log($"Predicted Fall Time: {predictedTime} seconds");
        rb.isKinematic = true;
    }

    [Button("Fall")]
    public void StartFall()
    {
        fallTimer = 0f;
        isFalling = true;
        onGround = false; 
        rb.isKinematic = false; 
    }

    void FixedUpdate()
    {
        if (isFalling)
        {
            fallTimer += Time.fixedDeltaTime;

            if (onGround)
            {
                actualFallTime = fallTimer;
                Debug.Log($"Actual fall time: {actualFallTime} seconds");
                rb.isKinematic = true; 
                isFalling = false;  
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true; 
        }
    }
}

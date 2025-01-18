using NaughtyAttributes;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private float distance, time;
    [SerializeField] private Rigidbody rb;
    private bool isStart;
    private float actualTime;
    private float speed;

    private void Update()
    {
        if (isStart)
        {
            actualTime += Time.deltaTime;
            if (actualTime / time < .99f)
            {
                rb.velocity = speed * Vector2.right;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }

    [Button]

    public void StartSpeed()
    {
        speed = distance / time;
        actualTime = 0;
        isStart = true;
    }

}

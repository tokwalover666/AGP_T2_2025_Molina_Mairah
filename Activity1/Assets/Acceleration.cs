using NaughtyAttributes;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] private float initialVelocity, finalVelocity, accelerationMaxSeconds;
    [SerializeField] private Rigidbody rbComponent;
    private bool flag = false;
    private float timer = 0;

    private void Start()
    {
        timer = 0;
        flag = false;
    }

    private void FixedUpdate()
    {
        if (flag)
        {
            timer += Time.deltaTime;
            Debug.Log(timer / accelerationMaxSeconds);
            rbComponent.velocity = Vector2.Lerp(new Vector2(initialVelocity, 0), new Vector2(finalVelocity, 0), timer / accelerationMaxSeconds);
        }
    }

    [Button]

    public void StartVelocityTravel()
    {
        flag = true;
    }
}

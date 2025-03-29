using UnityEngine;

public class ForceModeComparison : MonoBehaviour
{
    [SerializeField] Rigidbody rbImpulse, rbForce, rbAcceleration, rbVelocityChange;
    [SerializeField] Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rbImpulse.AddForce(-transform.forward * 500, ForceMode.Impulse);
            rbImpulse.useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rbForce.AddForce(-transform.forward * 500, ForceMode.Force);
            rbForce.useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rbAcceleration.AddForce(-transform.forward * 500, ForceMode.Acceleration);
            rbAcceleration.useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            rbVelocityChange.AddForce(-transform.forward * 500, ForceMode.VelocityChange);
            rbVelocityChange.useGravity = true;
        }


        //////////
        ///


        if (Input.GetKeyDown(KeyCode.H))
        {
            float mass = rbImpulse.mass;
            float impulseForce = 500f;
            Vector3 impulse = -transform.forward * impulseForce;
            Vector3 velocityChange = impulse / mass;
            rbImpulse.linearVelocity += velocityChange;

        }
    }

    private void OnMouseDown()
    {
        rbImpulse.AddForce(-transform.forward * 500 , ForceMode.Impulse);
        rbImpulse.useGravity = true;
    }

}
